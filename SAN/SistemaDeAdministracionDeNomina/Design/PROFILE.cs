using SistemaDeAdministracionDeNomina.DAO;
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

namespace SistemaDeAdministracionDeNomina.Design
{
    public partial class PROFILE : Form
    {
        private bool _passwordEditable = false; //toggle de edicion de contraseña

        public PROFILE()
        {
            InitializeComponent();
            CargarDatosUsuario();
            EstablecerPasswordEditable(false); //desactivados por default

            uC_save.Click += (s, e) => GuardarCambios();
        }

        private void CargarDatosUsuario()
        {
            var usuario = Session.UsuarioLogueado;
            if (usuario == null) return;

            pf_role.Text = usuario.RoleName;
            pf_updatedat.Text = usuario.UpdatedAt.HasValue
                ? $"{usuario.UpdatedAt.Value:HH:mm}"
                : "Never edited";

            pf_username.Text = usuario.Username;
            pf_first_name.Text = usuario.FirstName;
            pf_middle_name.Text = usuario.MiddleName;
            pf_last_name.Text = usuario.LastName;

            //No mostrar la contraseña por seguridad
            pf_current_password.Text = "";
            pf_new_password.Text = "";
            pf_confirm_new_password.Text = "";
        }

        //Toggle de edicion
        private void ToggleEdicionPassword()
        {
            EstablecerPasswordEditable(!_passwordEditable); // invierte el estado actual
        }

        //Solo activa los campos de la contraseña
        private void EstablecerPasswordEditable(bool activo)
        {
            _passwordEditable = activo;

            pf_current_password.ReadOnly = !activo;
            pf_new_password.ReadOnly = !activo;
            pf_confirm_new_password.ReadOnly = !activo;

            if (activo)
            {
                pf_current_password.Text = "";
                pf_new_password.Text = "";
                pf_confirm_new_password.Text = "";
                pf_current_password.Focus(); // el cursor empieza en el primer campo a llenar
            }
        }

        //Guardar los cambios hechos
        private void GuardarCambios()
        {
            string username = pf_username.Text.Trim();
            string firstName = pf_first_name.Text.Trim();
            string middleName = pf_middle_name.Text.Trim();
            string lastName = pf_last_name.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Usuario, nombre y apellido son obligatorios.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string currentPassword = pf_current_password.Text;
            string newPassword = pf_new_password.Text;
            string confirmNewPassword = pf_confirm_new_password.Text;

            // Si los campos de password siguen en ReadOnly, el usuario no
            // intentó cambiarla — solo actualizamos datos generales.
            bool intentaCambiarPassword = !pf_current_password.ReadOnly;

            string nuevaPasswordFinal = null; // null = no tocar la password actual

            if (intentaCambiarPassword)
            {
                if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmNewPassword))
                {
                    MessageBox.Show("Completa los 3 campos de contraseña para poder cambiarla.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (newPassword != confirmNewPassword)
                {
                    MessageBox.Show("La nueva contraseña y su confirmación no coinciden.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar que "Current Password" sea correcta antes de aceptar el cambio
                bool passwordActualValida = UsersDAO.VerificarPassword(Session.UsuarioLogueado.Id, currentPassword);
                if (!passwordActualValida)
                {
                    MessageBox.Show("La contraseña actual no es correcta.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                nuevaPasswordFinal = newPassword;
            }

            int userId = Session.UsuarioLogueado.Id;

            bool exito = UsersDAO.UpdateProfile(
                userId, firstName,
                string.IsNullOrWhiteSpace(middleName) ? null : middleName,
                lastName, username, nuevaPasswordFinal
            );

            if (!exito)
            {
                MessageBox.Show("No se pudo actualizar el perfil. El usuario ya existe o hubo un error.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UsersEntity actualizado = UsersDAO.ObtenerPorId(userId);
            Session.IniciarSesion(actualizado);

            CargarDatosUsuario();
            EstablecerPasswordEditable(false);

            MessageBox.Show("Perfil actualizado correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void uC_save_Load(object sender, EventArgs e)
        {

        }

        private void pf_edit_Click(object sender, EventArgs e)
        {
            ToggleEdicionPassword();
        }

        private void PROFILE_Load(object sender, EventArgs e)
        {

        }
    }
}