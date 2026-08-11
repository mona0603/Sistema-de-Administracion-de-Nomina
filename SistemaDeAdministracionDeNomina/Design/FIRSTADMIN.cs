using SistemaDeAdministracionDeNomina.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAdministracionDeNomina.Design
{
    public partial class FIRSTADMIN : Form
    {
        public FIRSTADMIN()
        {
            InitializeComponent();
        }

        private void firstadmin_create_Click(object sender, EventArgs e)
        {
            //Campos a verificar
            string username = firstadmin_username.Text.Trim();
            string password = firstadmin_pswrd.Text;
            string confirmPassword = firstadmin_confirmpswrd.Text;

            //Validar usuario
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter an email address.",
                                "Validation",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            //Validar contraseña
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter a password.",
                                "Validation",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            //Confirmar contraseña
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.",
                                "Validation",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            try
            {
                //Llamar a DAO y pasar los parametros del usuario y contraseña
                UsersDAO.CreateFirstAdministrator(username, password);

                MessageBox.Show("Administrator created successfully.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                //Entrar a la interface al registrarse
                INTERFACE IF = new INTERFACE();
                IF.Show();
                this.Hide(); //Oculta la pantalla anterior
            }
            catch (SqlException ex) //Retorna el error que surgió
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FIRSTADMIN_Load(object sender, EventArgs e)
        {

        }
    }
}
