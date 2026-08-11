using SistemaDeAdministracionDeNomina.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAdministracionDeNomina.Design
{
    public partial class DATACAPTURE : Form
    {
        // Control de contenido mostrado actualmente en d_panelcontent
        private UserControl _controlActual;

        // Módulo del sidebar (UC_Modules) actualmente seleccionado
        private UC_Modules _moduloActivo;

        // Una opción del menú superior (d_menustrip): su texto y qué
        // UserControl produce al hacer clic.
        private class OpcionMenu
        {
            public string Texto;
            public Func<UserControl> FabricaContenido;
        }

        // Qué opciones de menú le corresponden a cada módulo del sidebar
        private Dictionary<UC_Modules, List<OpcionMenu>> _menuPorModulo;

        // Mapeo entre el identificador abstracto (ModuleType) y el control
        // real del sidebar. Permite que otro formulario (INTERFACE) pida
        // "ábreme en Payroll" sin conocer d_uC_Modules3 directamente.
        private Dictionary<ModuleType, UC_Modules> _modulosPorTipo;

        // Texto de la opción de menú que se debe mostrar la PRIMERA vez
        // que se carga el módulo inicial (viene de otro formulario, ej.
        // INTERFACE pidiendo "Conceptos, pero específicamente Deducciones").
        // Se limpia después de usarse una sola vez.
        private string _opcionInicialPendiente;

        // ------------------------------------------------------------------
        // Estilo visual de las opciones del menú superior (d_menustrip).
        // AJUSTA estos valores a los que ya tenías (color de texto exacto,
        // tamaño de fuente, padding, etc.) — este es el ÚNICO lugar donde
        // se define, así que cualquier cambio futuro aplica a todas las
        // opciones de todos los módulos por igual.
        // ------------------------------------------------------------------
        private readonly Font _fuenteMenu = new Font("Segoe UI", 10F, FontStyle.Bold);
        private readonly Color _colorTextoMenu = Color.FromArgb(255, 255, 255); // <- cambia al color que tenías
        private readonly Padding _paddingMenu = new Padding(15, 5, 15, 5);

        /////////////////////////////////////////////////////////////////
        // ------------------------------------------------------------------
        // Elimina el parpadeo cuando varias cosas se repintan en cascada
        // en un solo clic (el módulo del sidebar que se resalta, el que se
        // des-resalta, la reconstrucción de d_menustrip, y el intercambio
        // de d_panelcontent). WS_EX_COMPOSITED le dice a Windows que arme
        // el formulario completo en memoria antes de mostrarlo, en vez de
        // pintar cada control por separado.
        //
        // Nota: activa esto en CADA formulario de tu proyecto que tenga
        // este tipo de actualizaciones múltiples simultáneas (no es
        // exclusivo de DATACAPTURE).
        // ------------------------------------------------------------------
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        // Constructor por default: requerido para que el diseñador de
        // Visual Studio pueda abrir DATACAPTURE en modo diseño (necesita
        // un constructor sin parámetros). Arranca en Employees.
        public DATACAPTURE() : this(ModuleType.Employees)
        {
        }

        /// <summary>
        /// Abre DATACAPTURE ya posicionado en el módulo indicado, y
        /// opcionalmente en una opción específica del menú de ese módulo.
        /// Ejemplos de invocación desde INTERFACE:
        ///   new DATACAPTURE(ModuleType.PayrollCapture)
        ///   new DATACAPTURE(ModuleType.Concepts, "Deducciones")
        /// </summary>
        public DATACAPTURE(ModuleType moduloInicial, string opcionInicial = null)
        {
            InitializeComponent();
            ActivarDobleBuffer(d_panelcontent); // evita el parpadeo al cambiar de UserControl
            ConfigurarMenusPorModulo();
            SuscribirModulosDelSidebar();

            _opcionInicialPendiente = opcionInicial;
            SeleccionarModulo(_modulosPorTipo[moduloInicial]);
        }

        // Panel no expone la propiedad DoubleBuffered públicamente (es
        // protected), así que se activa por reflexión. Reduce mucho el
        // parpadeo al agregar/quitar controles grandes dentro de él.
        private void ActivarDobleBuffer(Control control)
        {
            typeof(Control).InvokeMember(
                "DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null,
                control,
                new object[] { true });
        }

        private void d_uC_Modules1_Load(object sender, EventArgs e)
        {
        }

        // Go back botón
        private void d_back_Click_1(object sender, EventArgs e)
        {
            INTERFACE IF = new INTERFACE();
            IF.Show();
            this.Close(); //Oculta la pantalla anterior
        }

        // --------------------------------------------------------------
        // CONFIGURACIÓN — único lugar a editar cuando agregues o quites
        // opciones de algún módulo. Reemplaza los nombres de UserControls
        // de ejemplo (UC_EmployeesReportes, UC_Bancos, etc.) por los
        // reales conforme los vayas creando.
        // --------------------------------------------------------------
        private void ConfigurarMenusPorModulo()
        {
            _menuPorModulo = new Dictionary<UC_Modules, List<OpcionMenu>>
            {
                // Módulo 1: Employees
                [d_uC_Modules1] = new List<OpcionMenu>
                {
                    new OpcionMenu { Texto = "Capture",  FabricaContenido = () => new UC_Employees() },
                    //new OpcionMenu { Texto = "Reports", FabricaContenido = () => new UC_Reports().Configurar(ReportType.EmployeeReport) }, //movido a Catalogue
                    new OpcionMenu { Texto = "Load Excel",    FabricaContenido = () => new UC_Excel() },
                },

                // Módulo 2: Catalogue (Analiticas y reportes diversos)
                [d_uC_Modules2] = new List<OpcionMenu>
                {
                    new OpcionMenu { Texto = "Employee Report", FabricaContenido = () => new UC_Reports().Configurar(ReportType.EmployeeReport) },
                    new OpcionMenu { Texto = "General Payroll Report",        FabricaContenido = () => new UC_Reports().Configurar(ReportType.GeneralPayroll) },
                    new OpcionMenu { Texto = "Headcounter Report", FabricaContenido = () => new UC_Reports().Configurar(ReportType.Headcounter) },
                    new OpcionMenu { Texto = "Payroll Report",    FabricaContenido = () => new UC_Reports().Configurar(ReportType.Payroll) },
                },

                // Módulo 3: Concepts (catálogos que reutilizan UC_Concepts, cada uno
                // configurado con su ConceptType correspondiente)
                [d_uC_Modules3] = new List<OpcionMenu>
{
                    new OpcionMenu { Texto = "Perceptions", FabricaContenido = () => new UC_Concepts().Configurar(ConceptType.Perceptions) },
                    new OpcionMenu { Texto = "Deductions",  FabricaContenido = () => new UC_Concepts().Configurar(ConceptType.Deductions) },
                    new OpcionMenu { Texto = "Departments", FabricaContenido = () => new UC_Concepts().Configurar(ConceptType.Departments) },
                    new OpcionMenu { Texto = "Positions",   FabricaContenido = () => new UC_Concepts().Configurar(ConceptType.Positions) },
                    new OpcionMenu { Texto = "Banks",       FabricaContenido = () => new UC_Concepts().Configurar(ConceptType.Banks) },
                },

                // Módulo 4: Payroll Capture
                [d_uC_Modules4] = new List<OpcionMenu>
                {
                    new OpcionMenu { Texto = "Payroll Drafts", FabricaContenido = () => new UC_Concepts().Configurar(ConceptType.PayrollDrafts) },
                    new OpcionMenu { Texto = "Payrolls", FabricaContenido = () => new UC_Payroll() },
                },
            };

            // Relación ModuleType -> control real del sidebar
            _modulosPorTipo = new Dictionary<ModuleType, UC_Modules>
            {
                [ModuleType.Employees] = d_uC_Modules1,
                [ModuleType.Catalogue] = d_uC_Modules2,
                [ModuleType.Concepts] = d_uC_Modules3,
                [ModuleType.PayrollCapture] = d_uC_Modules4
            };
        }

        // --------------------------------------------------------------
        // Registro de cada módulo del sidebar. Ya no carga un solo
        // UserControl fijo: ahora reconstruye el menú de d_menustrip con
        // las opciones que le correspondan a ese módulo.
        // --------------------------------------------------------------
        private void SuscribirModulosDelSidebar()
        {
            foreach (var kvp in _menuPorModulo)
            {
                UC_Modules modulo = kvp.Key; // captura local, evita el bug clásico de closures en foreach
                modulo.Click += (s, e) => SeleccionarModulo(modulo);
            }
        }

        /// <summary>
        /// Marca el módulo del sidebar como seleccionado (usando su propia
        /// propiedad IsSelected) y reconstruye el menú superior con sus
        /// opciones correspondientes.
        /// </summary>
        private void SeleccionarModulo(UC_Modules modulo)
        {
            // Desmarcar el módulo anterior
            if (_moduloActivo != null)
                _moduloActivo.IsSelected = false;

            // Marcar el nuevo
            modulo.IsSelected = true;
            _moduloActivo = modulo;

            CargarMenuDeModulo(modulo);
        }

        // --------------------------------------------------------------
        // Reconstruye d_menustrip con las opciones del módulo activo.
        // Si viene una _opcionInicialPendiente (pedida desde otro
        // formulario, ej. INTERFACE), se muestra esa; si no, se muestra
        // la primera opción por default.
        // --------------------------------------------------------------
        private void CargarMenuDeModulo(UC_Modules modulo)
        {
            d_menustrip.Items.Clear();

            if (!_menuPorModulo.TryGetValue(modulo, out List<OpcionMenu> opciones))
                return;

            OpcionMenu opcionAMostrar = null;

            foreach (OpcionMenu opcion in opciones)
            {
                var item = new ToolStripMenuItem(opcion.Texto)
                {
                    Font = _fuenteMenu,
                    ForeColor = _colorTextoMenu,
                    Padding = _paddingMenu,
                };
                item.Click += (s, e) => CargarUserControl(opcion.FabricaContenido());
                d_menustrip.Items.Add(item);

                if (_opcionInicialPendiente != null &&
                    string.Equals(opcion.Texto, _opcionInicialPendiente, StringComparison.OrdinalIgnoreCase))
                {
                    opcionAMostrar = opcion;
                }
            }

            if (opcionAMostrar == null && opciones.Count > 0)
                opcionAMostrar = opciones[0]; // default: primera opción del módulo

            _opcionInicialPendiente = null; // ya se usó, no debe aplicar en próximos cambios de módulo

            if (opcionAMostrar != null)
                CargarUserControl(opcionAMostrar.FabricaContenido());
        }

        // --------------------------------------------------------------
        // Intercambio de contenido dentro de d_panelcontent
        //
        // Dos ajustes para evitar el parpadeo/glitch visual al cambiar
        // de control:
        //   1. Se agrega el control NUEVO antes de quitar el viejo (así
        //      el panel nunca queda vacío ni un frame).
        //   2. Se activa el doble buffer de d_panelcontent por reflexión,
        //      ya que Panel no expone esa propiedad públicamente.
        // --------------------------------------------------------------
        private void CargarUserControl(UserControl nuevoControl)
        {
            d_panelcontent.SuspendLayout();

            nuevoControl.Visible = false; // se arma "detrás de cámaras" antes de mostrarlo
            nuevoControl.Dock = DockStyle.Fill;
            d_panelcontent.Controls.Add(nuevoControl);
            nuevoControl.BringToFront();

            if (_controlActual != null)
            {
                d_panelcontent.Controls.Remove(_controlActual);
                _controlActual.Dispose(); // libera memoria del control anterior
            }

            nuevoControl.Visible = true;
            _controlActual = nuevoControl;

            d_panelcontent.ResumeLayout();
        }

        private void DATACAPTURE_Load(object sender, EventArgs e)
        {
        }

        private void employeesCaptureToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dfgfgToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}