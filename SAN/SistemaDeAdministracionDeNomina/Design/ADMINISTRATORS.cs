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
    public partial class ADMINISTRATORS : Form
    {
        private UserControl _controlActual;
        public ADMINISTRATORS()
        {
            InitializeComponent();

            ActivarDobleBuffer(a_panelcontent);

            ConfigurarAccesoMenu();
            ConectarMenu();
        }

        private void ConfigurarAccesoMenu()
        {
            // SUPER_ADMIN (1) y ADMIN (2) pueden acceder a Users.
            // HR (3) y ACCOUNTANT (4) solo pueden acceder a Reports.
            a_menu_op1.Visible =
                Session.UsuarioLogueado.RoleId <= 2;
        }

        private void ConectarMenu()
        {
            // Users
            a_menu_op1.Click += (s, e) =>
            {
                if (Session.UsuarioLogueado.RoleId > 2)
                    return;

                CargarUserControl(
                    new UC_Concepts()
                        .Configurar(ConceptType.Administrators));
            };

            // Reports
            a_menu_op2.Click += (s, e) =>
            {
                CargarUserControl(
                    new UC_Reports()
                        .Configurar(ReportType.Administrators));
            };
        }

        private void CargarUserControl(UserControl nuevoControl)
        {
            a_panelcontent.SuspendLayout();

            nuevoControl.Visible = false;
            nuevoControl.Dock = DockStyle.Fill;

            a_panelcontent.Controls.Add(nuevoControl);
            nuevoControl.BringToFront();

            if (_controlActual != null)
            {
                a_panelcontent.Controls.Remove(_controlActual);
                _controlActual.Dispose();
            }

            nuevoControl.Visible = true;
            _controlActual = nuevoControl;

            a_panelcontent.ResumeLayout();
        }

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


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void a_division_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ADMINISTRATORS_Load(object sender, EventArgs e)
        {

        }

        private void a_back_Click(object sender, EventArgs e)
        {
            INTERFACE IF = new INTERFACE();
            IF.Show();
            this.Close(); //Oculta la pantalla anterior
        }

        private void a_menustrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
