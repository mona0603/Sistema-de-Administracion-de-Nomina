using SistemaDeAdministracionDeNomina.DAO;
using SistemaDeAdministracionDeNomina.Design;
using SistemaDeAdministracionDeNomina.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAdministracionDeNomina
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void login_login_Click(object sender, EventArgs e)
        {
            UsersEntity user = UsersDAO.ValidateLogin(
                login_username.Text.Trim(),
                login_password.Text
            );

            if (user == null)
            {
                MessageBox.Show("Invalid username or password.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            else
            {
                Session.IniciarSesion(user);
                MessageBox.Show($"Welcome, {user.Username}",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                INTERFACE IF = new INTERFACE(); //crea una instancia del objeto
                IF.Show(); //Muestra la pantalla anterior
                this.Hide(); //Oculta la pantalla anterior
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
