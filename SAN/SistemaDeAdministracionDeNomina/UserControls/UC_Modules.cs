using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAdministracionDeNomina.UserControls
{
    public partial class UC_Modules : UserControl
    {
        //      Cambio de diseño (color de fondo)
        private Color colorNormal = Color.Transparent;   // transparente
        private Color colorHover = Color.FromArgb(224, 224, 224);   // un tono más claro
        private Color colorSeleccionado = Color.FromArgb(255, 255, 255); // opcional, para el activo
        private bool isSelected = false;

        //      Cambio de diseño (color de texto del título)
        // Se captura el valor original del diseñador en el constructor,
        // así que si cambias el ForeColor de ucm_title en el diseñador, ese
        // sigue siendo el color "normal" automáticamente.
        private Color colorTextoNormal;
        private Color colorTextoSeleccionado = Color.FromArgb(64, 64, 64); // ajusta al tono que uses de "activo"

        public bool IsSelected
        {
            get => isSelected;
            set
            {
                isSelected = value;
                ActualizarColor();
            }
        }

        // ------------------------------------------------------------------
        // Íconos de ucm_go para estado normal / seleccionado.
        //
        // GoIconNormal usa el patrón ShouldSerialize/Reset: si nunca lo
        // tocas en el Properties window, se resuelve solo con lo que
        // ucm_go ya tiene puesto en el diseñador. Si SÍ lo asignas
        // explícitamente ahí, el diseñador ahora detecta el cambio
        // correctamente y lo guarda en el .Designer.cs (antes no lo hacía,
        // porque su "default" se calculaba en tiempo real y el diseñador
        // no sabía compararlo).
        // ------------------------------------------------------------------
        private Image _goIconNormal;

        [Category("Estado del módulo")]
        [Description("Ícono de la flecha/indicador cuando el módulo NO está seleccionado.")]
        public Image GoIconNormal
        {
            get => _goIconNormal ?? ucm_go.Image;
            set => _goIconNormal = value;
        }

        // Métodos que le dicen al diseñador de WinForms CUÁNDO debe guardar
        // GoIconNormal: solo si el usuario lo asignó explícitamente.
        private bool ShouldSerializeGoIconNormal() => _goIconNormal != null;
        private void ResetGoIconNormal() => _goIconNormal = null;

        [Category("Estado del módulo")]
        [Description("Ícono de la flecha/indicador cuando el módulo SÍ está seleccionado.")]
        public Image GoIconSeleccionado { get; set; }

        private void SuscribirEventosHover()
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.MouseEnter += OnMouseEnter;
                ctrl.MouseLeave += OnMouseLeave;
            }
            this.MouseEnter += OnMouseEnter;
            this.MouseLeave += OnMouseLeave;
        }

        private void SuscribirEventosClick()
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Click += (s, e) => this.OnClick(EventArgs.Empty);
            }
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            if (!isSelected)
                this.BackColor = colorHover;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            if (!isSelected)
                this.BackColor = colorNormal;
        }

        // ------------------------------------------------------------------
        // Aplica el color de fondo, el color del título y el ícono de
        // ucm_go según el estado (seleccionado o no).
        // ------------------------------------------------------------------
        private void ActualizarColor()
        {
            this.BackColor = isSelected ? colorSeleccionado : colorNormal;
            ucm_title.ForeColor = isSelected ? colorTextoSeleccionado : colorTextoNormal;

            if (GoIconSeleccionado != null)
                ucm_go.Image = isSelected ? GoIconSeleccionado : GoIconNormal;
        }

        public UC_Modules()
        {
            InitializeComponent();

            // Captura el color de texto original del diseñador como el
            // valor "normal" por defecto (GoIconNormal ya se resuelve solo
            // mediante su getter, no hace falta capturarlo aquí).
            colorTextoNormal = ucm_title.ForeColor;

            SuscribirEventosHover();
            SuscribirEventosClick();
        }

        private void UC_Modules_Load(object sender, EventArgs e)
        {
        }

        //Manipulación de titulo y icono
        public string CardTitle
        {
            get => ucm_title.Text;
            set => ucm_title.Text = value;
        }

        public Image CardImage
        {
            get { return ucm_icon.Image; }
            set { ucm_icon.Image = value; }
        }
    }
}