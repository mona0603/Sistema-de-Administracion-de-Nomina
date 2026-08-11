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
    public partial class INTERFACE : Form
    {
        public INTERFACE()
        {
            InitializeComponent();

            //MessageBox.Show(Session.UsuarioLogueado == null
            //? "NULL: la sesión no se guardó"
            //: $"Usuario: '{Session.UsuarioLogueado.Username}'");

            // Muestra el usuario que inició sesión (guardado en LOGIN al
            // validar credenciales). Si por alguna razón no hay sesión activa
            // (ej. alguien accedió a este formulario sin pasar por LOGIN),
            // se evita un NullReferenceException con el operador ?.
            if_username.Text = Session.UsuarioLogueado?.Username;
            if_lastlogin.Text = Session.UsuarioLogueado?.LastLogin != null
            ? Session.UsuarioLogueado.LastLogin.Value.ToString("dd/MM/yyyy HH:mm")
            : "—";

            // Los 4 módulos reales: cada card abre DATACAPTURE ya
            // posicionado en su módulo correspondiente del sidebar.
            uC_Cards1.CardClicked += (s, e) => GoTo(new DATACAPTURE(ModuleType.Employees));
            uC_Cards2.CardClicked += (s, e) => GoTo(new DATACAPTURE(ModuleType.Catalogue));
            uC_Cards3.CardClicked += (s, e) => GoTo(new DATACAPTURE(ModuleType.Concepts));
            uC_Cards4.CardClicked += (s, e) => GoTo(new DATACAPTURE(ModuleType.PayrollCapture));

            //Administradores
            uC_Cards6.CardClicked += (s, e) => GoTo(new ADMINISTRATORS());
        }

        // Navegación al Form correspondiente
        private void GoTo(Form formulario)
        {
            formulario.Show();
            this.Close(); //destruye la pantalla anterior
        }

        private void if_logout_Click(object sender, EventArgs e)
        {
            //Cerrar la sesión
            Session.CerrarSesion();

            LOGIN LG = new LOGIN();
            LG.Show();
            this.Close(); //Oculta la pantalla anterior
        }

        private void INTERFACE_Load(object sender, EventArgs e)
        {
        }

        private void uC_Cards1_Load(object sender, EventArgs e)
        {
        }

        private void if_manage_Click(object sender, EventArgs e)
        {
            PROFILE PF = new PROFILE();
            PF.Show();
        }

        private void if_username_Click(object sender, EventArgs e)
        {

        }
    }
}