// Para saber qué información llenar en el DataGrid
// dependiendo del módulo que se esté utilizando.

using SistemaDeAdministracionDeNomina.DAO;
using SistemaDeAdministracionDeNomina.Design;
using SistemaDeAdministracionDeNomina.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDeAdministracionDeNomina.UserControls
{
    public partial class UC_Concepts : UserControl
    {
        // ==============================================================
        // CAMPOS
        // ==============================================================
        private ConceptType _tipo;

        // Usuario actualmente seleccionado para edición.
        private int? _idSeleccionado;

        // Información original del usuario al comenzar Edit.
        // Se utiliza para detectar si realmente hubo cambios.
        private string _usernameOriginal;
        private int _roleIdOriginal;

        // ==============================================================
        // CONSTRUCTOR / CONFIGURACIÓN
        // ==============================================================
        public UC_Concepts()
        {
            InitializeComponent();

            ucc_data.SelectionChanged += ucc_data_SelectionChanged;
        }

        public UC_Concepts Configurar(ConceptType tipo)
        {
            _tipo = tipo;

            CargarGrid();
            ConfigurarCamposVisibles();
            CargarComboOrdenar();
            EstablecerReadOnly(true);
            CargarToolbar();

            return this;
        }

        // ==============================================================
        // PERMISOS
        // ==============================================================

        // La jerarquía es:
        //
        // 1 = SUPER_ADMIN
        // 2 = ADMIN
        // 3 = HR
        // 4 = ACCOUNTANT
        //
        // Un usuario puede editar a otro usuario que tenga
        // su mismo nivel o un nivel inferior.
        //
        // Ejemplo:
        //
        // ADMIN (2) -> ADMIN (2)       Sí
        // ADMIN (2) -> HR (3)          Sí
        // ADMIN (2) -> ACCOUNTANT (4)  Sí
        // ADMIN (2) -> SUPER_ADMIN (1) No
        //
        private bool PuedeEditarRol(int roleIdObjetivo)
        {
            return Session.UsuarioLogueado.RoleId <= roleIdObjetivo;
        }

        // Solo SUPER_ADMIN puede desactivar usuarios.
        private bool PuedeDesactivarUsuarios()
        {
            return Session.UsuarioLogueado.RoleId == 1;
        }

        // Solo SUPER_ADMIN puede reactivar usuarios.
        private bool PuedeReactivarUsuarios()
        {
            return Session.UsuarioLogueado.RoleId == 1;
        }

        // SUPER_ADMIN y ADMIN pueden crear usuarios.
        private bool PuedeCrearUsuarios()
        {
            return Session.UsuarioLogueado.RoleId <= 2;
        }

        // Solo SUPER_ADMIN puede modificar el rol de un usuario.
        private bool PuedeCambiarRol()
        {
            return Session.UsuarioLogueado.RoleId == 1;
        }

        // ==============================================================
        // GRID
        // ==============================================================
        private void CargarGrid()
        {
            DataTable datos;

            if (_tipo == ConceptType.Administrators)
            {
                // ConceptsDAO se encarga de excluir los usuarios
                // que no deben aparecer en este listado.
                datos = ConceptsDAO.ObtenerDatos(
                    _tipo,
                    Session.UsuarioLogueado.Id);
            }
            else
            {
                datos = ConceptsDAO.ObtenerDatos(_tipo);
            }

            ucc_data.DataSource = datos;

            if (ucc_data.Columns.Contains("ID"))
                ucc_data.Columns["ID"].Visible = false;

            if (ucc_data.Columns.Contains("RoleId"))
                ucc_data.Columns["RoleId"].Visible = false;
        }

        // ==============================================================
        // SELECCIÓN DEL DATAGRID
        // ==============================================================
        private void ucc_data_SelectionChanged(object sender, EventArgs e)
        {
            if (ucc_data.CurrentRow == null)
                return;

            if (_tipo != ConceptType.Administrators)
                return;

            DataGridViewRow fila = ucc_data.CurrentRow;

            ucc_title.Text =
                fila.Cells["Username"].Value?.ToString();

            // Nunca mostramos la contraseña existente.
            ucc_description.Clear();

            ucc_code.Text =
                fila.Cells["ID"].Value?.ToString();

            string roleActual =
                fila.Cells["Role"].Value?.ToString();

            if (ucc_calculateby.Items.Contains(roleActual))
                ucc_calculateby.SelectedItem = roleActual;
        }

        private int? ObtenerIdSeleccionado()
        {
            if (ucc_data.CurrentRow == null)
                return null;

            return Convert.ToInt32(
                ucc_data.CurrentRow.Cells["ID"].Value);
        }

        // ==============================================================
        // TOOLBAR
        // ==============================================================
        private void CargarToolbar()
        {
            if (_tipo == ConceptType.Administrators)
            {
                ConfigurarToolbarAdministrators();
                return;
            }

            uC_Toolbar1.ClearButtons();

            if (_tipo == ConceptType.PayrollDrafts)
            {
                uC_Toolbar1.AddButton(
                    "Generate Period",
                    Properties.Resources.folder,
                    Color.Green,
                    (s, e) => GenerarPeriodo());

                uC_Toolbar1.AddButton(
                    "Process All",
                    Properties.Resources.marca_de_verificacion,
                    Color.Gold,
                    (s, e) => ProcesarTodo());

                uC_Toolbar1.AddButton(
                    "Edit",
                    Properties.Resources.pencil1,
                    Color.Gold,
                    (s, e) => EditarBorrador());

                return;
            }

            uC_Toolbar1.AddButton(
                "Add",
                Properties.Resources.folder,
                Color.Green,
                (s, e) => AgregarNuevo());

            uC_Toolbar1.AddButton(
                "Edit",
                Properties.Resources.pencil1,
                Color.Gold,
                (s, e) => EditarSeleccionado());

            uC_Toolbar1.AddButton(
                "Delete",
                Properties.Resources.bin1,
                Color.Red,
                (s, e) => EliminarSeleccionado());
        }

        // ==============================================================
        // TOOLBAR - ADMINISTRATORS
        // ==============================================================
        private void ConfigurarToolbarAdministrators()
        {
            uC_Toolbar1.ClearButtons();

            // SUPER_ADMIN y ADMIN pueden crear usuarios.
            if (PuedeCrearUsuarios())
            {
                uC_Toolbar1.AddButton(
                    "Add",
                    Properties.Resources.folder,
                    Color.Green,
                    (s, e) => AgregarUsuario());
            }

            // SUPER_ADMIN y ADMIN pueden editar.
            uC_Toolbar1.AddButton(
                "Edit",
                Properties.Resources.pencil1,
                Color.Gold,
                (s, e) => PrepararEdicionUsuario());

            // Solo SUPER_ADMIN puede desactivar.
            if (PuedeDesactivarUsuarios())
            {
                uC_Toolbar1.AddButton(
                    "Delete",
                    Properties.Resources.bin1,
                    Color.Red,
                    (s, e) => DesactivarUsuario());
            }
        }

        // ==============================================================
        // TOOLBAR - NUEVO USUARIO
        // ==============================================================

        private void ConfigurarToolbarGuardarNuevo()
        {
            uC_Toolbar1.ClearButtons();

            uC_Toolbar1.AddButton(
                "Save",
                Properties.Resources.marca_de_verificacion,
                Color.Green,
                (s, e) => GuardarNuevoUsuario());

            uC_Toolbar1.AddButton(
                "Cancel",
                Properties.Resources.bin1,
                Color.Red,
                (s, e) => CancelarNuevoUsuario());
        }

        // ==============================================================
        // TOOLBAR - EDITAR USUARIO
        // ==============================================================
        private void ConfigurarToolbarGuardarEdicion()
        {
            uC_Toolbar1.ClearButtons();

            uC_Toolbar1.AddButton(
                "Save",
                Properties.Resources.marca_de_verificacion,
                Color.Green,
                (s, e) => GuardarEdicionUsuario());

            uC_Toolbar1.AddButton(
                "Cancel",
                Properties.Resources.bin1,
                Color.Red,
                (s, e) => CancelarEdicionUsuario());
        }

        // ==============================================================
        // VISIBILIDAD DE CAMPOS
        // ==============================================================
        private void ConfigurarCamposVisibles()
        {
            bool esPayrollDrafts =
                _tipo == ConceptType.PayrollDrafts;

            bool esCatalogoSimple =
                _tipo == ConceptType.Departments ||
                _tipo == ConceptType.Positions ||
                _tipo == ConceptType.Banks;

            bool esAdminUsers =
                _tipo == ConceptType.Administrators;

            // ----------------------------------------------------------
            // Title / Description
            // ----------------------------------------------------------
            SetVisible(
                !esPayrollDrafts,
                ucc_title,
                ucc_titlelabel,
                ucc_description,
                ucc_descriptionlabel,
                ucc_reactivate,
                ucc_reactivate_pic,
                panel1,
                panel2);

            // ----------------------------------------------------------
            // System Type
            // ----------------------------------------------------------
            SetVisible(
                !esPayrollDrafts &&
                !esCatalogoSimple &&
                !esAdminUsers,
                ucc_systemtype,
                ucc_systemtype_pic,
                label1);

            // ----------------------------------------------------------
            // Calculate by / Role Type
            // ----------------------------------------------------------
            SetVisible(
                !esPayrollDrafts &&
                !esCatalogoSimple,
                ucc_calculateby,
                ucc_calculateby_pic,
                label2);

            // ----------------------------------------------------------
            // Administrators
            // ----------------------------------------------------------
            if (esAdminUsers)
            {
                ucc_titlelabel.Text = "User:";
                ucc_descriptionlabel.Text = "Password:";

                ucc_description.UseSystemPasswordChar = true;

                label2.Text = "Role Type:";

                // Solo SUPER_ADMIN puede reactivar.
                ucc_reactivate.Visible =
                    PuedeReactivarUsuarios();

                ucc_reactivate_pic.Visible =
                    PuedeReactivarUsuarios();

                // SUPER_ADMIN y ADMIN pueden seleccionar roles
                // durante ADD.
                ucc_calculateby.Enabled =
                    PuedeCrearUsuarios();
            }
            else
            {
                ucc_titlelabel.Text = "Title:";
                ucc_descriptionlabel.Text = "Description:";

                ucc_description.UseSystemPasswordChar = false;

                label2.Text = "Calculate by:";
            }
        }

        private void SetVisible(
            bool visible,
            params Control[] controles)
        {
            foreach (Control control in controles)
                control.Visible = visible;
        }

        // ==============================================================
        // READ ONLY
        // ==============================================================
        private void EstablecerReadOnly(bool soloLectura)
        {
            ucc_title.ReadOnly = soloLectura;
            ucc_description.ReadOnly = soloLectura;
        }

        // ==============================================================
        // LIMPIAR CAMPOS
        // ==============================================================
        private void LimpiarCampos()
        {
            ucc_title.Clear();
            ucc_description.Clear();
            ucc_code.Clear();

            _idSeleccionado = null;
            _usernameOriginal = null;
            _roleIdOriginal = 0;
        }

        // ==============================================================
        // COMBOS
        // ==============================================================
        private void CargarComboOrdenar()
        {
            ucc_sortby.Items.Clear();

            ucc_sortby.DropDownStyle =
                ComboBoxStyle.DropDownList;

            ucc_calculateby.Items.Clear();

            ucc_calculateby.DropDownStyle =
                ComboBoxStyle.DropDownList;


            switch (_tipo)
            {
                case ConceptType.Departments:
                case ConceptType.Positions:
                case ConceptType.Banks:

                    ucc_sortby.Items.Add("A-Z");
                    ucc_sortby.Items.Add("Z-A");
                    ucc_sortby.Items.Add("Code");
                    ucc_sortby.Items.Add("Active");
                    ucc_sortby.Items.Add("Inactive");

                    break;


                case ConceptType.Perceptions:
                case ConceptType.Deductions:

                    ucc_sortby.Items.Add("A-Z");
                    ucc_sortby.Items.Add("Z-A");
                    ucc_sortby.Items.Add("Code");
                    ucc_sortby.Items.Add("System type");
                    ucc_sortby.Items.Add("Active");
                    ucc_sortby.Items.Add("Inactive");

                    ucc_calculateby.Items.Add("Manual");
                    ucc_calculateby.Items.Add("Automatic");

                    break;


                case ConceptType.Administrators:

                    ucc_sortby.Items.Add("A-Z");
                    ucc_sortby.Items.Add("Z-A");
                    ucc_sortby.Items.Add("Active");
                    ucc_sortby.Items.Add("Inactive");


                    // --------------------------------------------------
                    // Roles que puede CREAR el usuario actual.
                    //
                    // SUPER_ADMIN:
                    //   SUPER_ADMIN
                    //   ADMIN
                    //   HR
                    //   ACCOUNTANT
                    //
                    // ADMIN:
                    //   ADMIN
                    //   HR
                    //   ACCOUNTANT
                    // --------------------------------------------------

                    if (Session.UsuarioLogueado.RoleId == 1)
                    {
                        ucc_calculateby.Items.Add(
                            "SUPER_ADMIN");
                    }

                    if (Session.UsuarioLogueado.RoleId <= 2)
                    {
                        ucc_calculateby.Items.Add(
                            "ADMIN");

                        ucc_calculateby.Items.Add(
                            "HR");

                        ucc_calculateby.Items.Add(
                            "ACCOUNTANT");
                    }

                    break;


                case ConceptType.PayrollDrafts:

                    ucc_sortby.Items.Add("Code");

                    break;


                default:

                    ucc_sortby.Items.Add("A-Z");
                    ucc_sortby.Items.Add("Z-A");

                    break;
            }


            ucc_sortby.SelectedIndexChanged -=
                SortBy_SelectedIndexChanged;

            ucc_sortby.SelectedIndexChanged +=
                SortBy_SelectedIndexChanged;


            if (ucc_sortby.Items.Count > 0)
                ucc_sortby.SelectedIndex = 0;

            if (ucc_calculateby.Items.Count > 0)
                ucc_calculateby.SelectedIndex = 0;
        }

        private int ObtenerRoleIdSeleccionado()
        {
            string roleName =
                ucc_calculateby.SelectedItem?.ToString();

            return UsersDAO.ObtenerRoleIdPorNombre(roleName);
        }

        private void SeleccionarRolPredeterminado()
        {
            string rolPredeterminado;

            if (Session.UsuarioLogueado.RoleId == 1)
            {
                rolPredeterminado = "SUPER_ADMIN";
            }
            else
            {
                rolPredeterminado = "ADMIN";
            }

            if (ucc_calculateby.Items.Contains(
                rolPredeterminado))
            {
                ucc_calculateby.SelectedItem =
                    rolPredeterminado;
            }
        }

        // ==============================================================
        // ORDENAMIENTO
        // ==============================================================
        private void SortBy_SelectedIndexChanged(object sender,EventArgs e){AplicarOrden();}

        private void AplicarOrden()
        {
            // Pendiente de implementar cuando se definan
            // las columnas definitivas de cada catálogo.
        }

        // ==============================================================
        // ADMINISTRATORS - ADD
        // ==============================================================

        // ADD solamente prepara una captura nueva.
        // NO crea el usuario aquí.
        private void AgregarUsuario()
        {
            if (!PuedeCrearUsuarios())
            {
                MessageBox.Show(
                    "You do not have permission to create users.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Limpiar cualquier selección anterior.
            ucc_data.ClearSelection();

            LimpiarCampos();

            // Durante ADD sí se puede seleccionar el rol.
            ucc_calculateby.Enabled = true;

            SeleccionarRolPredeterminado();

            EstablecerReadOnly(false);

            ConfigurarToolbarGuardarNuevo();

            ucc_title.Focus();
        }

        // ==============================================================
        // ADMINISTRATORS - SAVE NEW USER
        // ==============================================================
        private void GuardarNuevoUsuario()
        {
            if (!PuedeCrearUsuarios())
            {
                MessageBox.Show(
                    "You do not have permission to create users.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string username =
                ucc_title.Text.Trim();

            string password =
                ucc_description.Text;

            // ----------------------------------------------------------
            // Username
            // ----------------------------------------------------------
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show(
                    "Username cannot be empty.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // ----------------------------------------------------------
            // Password
            // ----------------------------------------------------------
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show(
                    "Password is required for a new user.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // ----------------------------------------------------------
            // Username duplicado
            // ----------------------------------------------------------
            if (UsersDAO.ExisteUsername(username))
            {
                MessageBox.Show(
                    $"Username '{username}' already exists.",
                    "Duplicate Username",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // ----------------------------------------------------------
            // Role
            // ----------------------------------------------------------
            int roleId =
                ObtenerRoleIdSeleccionado();

            if (roleId <= 0)
            {
                MessageBox.Show(
                    "Select a valid role.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // ----------------------------------------------------------
            // Validación de jerarquía
            // ----------------------------------------------------------
            if (roleId < Session.UsuarioLogueado.RoleId)
            {
                MessageBox.Show(
                    "You cannot create a user with a higher role than your own.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // ----------------------------------------------------------
            // Confirmación
            // ----------------------------------------------------------
            DialogResult confirmacion =
                MessageBox.Show(
                    "Are you sure you want to create this user?",
                    "Confirm Creation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            // ----------------------------------------------------------
            // INSERT
            // ----------------------------------------------------------
            bool exito =
                UsersDAO.CrearUsuario(
                    username,
                    password,
                    roleId,
                    Session.UsuarioLogueado.Id);

            if (!exito)
            {
                MessageBox.Show(
                    "The user could not be created.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show(
                "User created successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            FinalizarOperacionUsuario();
        }

        // ==============================================================
        // ADMINISTRATORS - CANCEL NEW USER
        // ==============================================================
        private void CancelarNuevoUsuario()
        {
            LimpiarCampos();

            ucc_data.ClearSelection();

            FinalizarOperacionUsuario();
        }

        // ==============================================================
        // ADMINISTRATORS - EDIT
        // ==============================================================
        // EDIT solamente prepara la edición.
        // NO guarda nada hasta presionar Save.
        private void PrepararEdicionUsuario()
        {
            int? id =
                ObtenerIdSeleccionado();

            if (id == null)
            {
                MessageBox.Show(
                    "Select a user first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int roleIdObjetivo =
                Convert.ToInt32(
                    ucc_data.CurrentRow.Cells["RoleId"].Value);

            // ADMIN puede editar su mismo nivel o inferiores.
            // SUPER_ADMIN puede editar cualquier nivel.
            if (!PuedeEditarRol(roleIdObjetivo))
            {
                MessageBox.Show(
                    "You do not have permission to edit this user.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            _idSeleccionado =
                id.Value;

            _usernameOriginal =
                ucc_data.CurrentRow.Cells["Username"]
                .Value?.ToString();

            _roleIdOriginal =
                roleIdObjetivo;

            // Nunca cargamos la contraseña actual.
            // Vacío significa conservar la contraseña actual.
            ucc_description.Clear();

            // ----------------------------------------------------------
            // Role Type
            // ----------------------------------------------------------
            //
            // SUPER_ADMIN puede cambiar el rol.
            // ADMIN NO puede cambiar el rol.
            //

            ucc_calculateby.Enabled =
                PuedeCambiarRol();

            EstablecerReadOnly(false);

            ConfigurarToolbarGuardarEdicion();

            ucc_title.Focus();
        }

        // ==============================================================
        // ADMINISTRATORS - SAVE EDIT
        // ==============================================================
        private void GuardarEdicionUsuario()
        {
            if (_idSeleccionado == null)
            {
                MessageBox.Show(
                    "No user is selected for editing.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string usernameNuevo =
                ucc_title.Text.Trim();

            string passwordNueva =
                ucc_description.Text;

            // ----------------------------------------------------------
            // Username
            // ----------------------------------------------------------
            if (string.IsNullOrWhiteSpace(usernameNuevo))
            {
                MessageBox.Show(
                    "Username cannot be empty.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // ----------------------------------------------------------
            // Role
            // ----------------------------------------------------------
            int nuevoRoleId;

            if (PuedeCambiarRol())
            {
                nuevoRoleId =
                    ObtenerRoleIdSeleccionado();

                if (nuevoRoleId <= 0)
                {
                    MessageBox.Show(
                        "Select a valid role.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Incluso SUPER_ADMIN no puede asignar
                // un rol que no exista en el ComboBox.
                if (nuevoRoleId < 1 ||
                    nuevoRoleId > 4)
                {
                    MessageBox.Show(
                        "The selected role is invalid.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
            }
            else
            {
                // ADMIN nunca puede modificar el rol.
                nuevoRoleId =
                    _roleIdOriginal;
            }

            // ----------------------------------------------------------
            // Detectar cambios
            // ----------------------------------------------------------
            bool cambioUsername =
                !string.Equals(
                    _usernameOriginal,
                    usernameNuevo,
                    StringComparison.Ordinal);

            bool cambioPassword =
                !string.IsNullOrEmpty(
                    passwordNueva);

            bool cambioRole =
                nuevoRoleId != _roleIdOriginal;

            if (!cambioUsername &&
                !cambioPassword &&
                !cambioRole)
            {
                MessageBox.Show(
                    "No changes were detected.",
                    "No Changes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            // ----------------------------------------------------------
            // Username duplicado
            // ----------------------------------------------------------
            if (cambioUsername &&
                UsersDAO.ExisteUsername(
                    usernameNuevo,
                    _idSeleccionado.Value))
            {
                MessageBox.Show(
                    $"Username '{usernameNuevo}' is already in use by another account.",
                    "Duplicate Username",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // ----------------------------------------------------------
            // Confirmación
            // ----------------------------------------------------------
            DialogResult confirmacion =
                MessageBox.Show(
                    "Are you sure you want to modify this user?",
                    "Confirm Changes",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            // ----------------------------------------------------------
            // Password
            // ----------------------------------------------------------
            string nuevaPassword =
                string.IsNullOrEmpty(passwordNueva)
                    ? null
                    : passwordNueva;

            // ----------------------------------------------------------
            // UPDATE
            // ----------------------------------------------------------
            bool exito =
                UsersDAO.ActualizarUsuario(
                    _idSeleccionado.Value,
                    usernameNuevo,
                    nuevaPassword,
                    nuevoRoleId,
                    Session.UsuarioLogueado.Id);

            if (!exito)
            {
                MessageBox.Show(
                    "The user could not be updated.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show(
                "User updated successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            FinalizarOperacionUsuario();
        }

        // ==============================================================
        // ADMINISTRATORS - CANCEL EDIT
        // ==============================================================
        private void CancelarEdicionUsuario()
        {
            // Restaurar username original.
            if (ucc_data.CurrentRow != null)
            {
                ucc_title.Text =
                    _usernameOriginal ?? "";

                // Nunca restauramos una contraseña.
                ucc_description.Clear();

                // Restaurar rol original.
                string roleName =
                    ucc_data.CurrentRow
                    .Cells["Role"]
                    .Value?.ToString();

                if (ucc_calculateby.Items.Contains(
                    roleName))
                {
                    ucc_calculateby.SelectedItem =
                        roleName;
                }
            }

            _idSeleccionado = null;
            _usernameOriginal = null;
            _roleIdOriginal = 0;

            FinalizarOperacionUsuario();
        }

        // ==============================================================
        // FINALIZAR OPERACIÓN DE USUARIO
        // ==============================================================
        private void FinalizarOperacionUsuario()
        {
            CargarGrid();

            LimpiarCampos();

            EstablecerReadOnly(true);

            // Restaurar estado normal del Role Type.
            ucc_calculateby.Enabled =
                PuedeCrearUsuarios();

            ConfigurarToolbarAdministrators();
        }

        // ==============================================================
        // ADMINISTRATORS - DELETE
        // ==============================================================
        private void DesactivarUsuario()
        {
            // ----------------------------------------------------------
            // Solo SUPER_ADMIN
            // ----------------------------------------------------------
            if (!PuedeDesactivarUsuarios())
            {
                MessageBox.Show(
                    "You do not have permission to deactivate users.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            int? id =
                ObtenerIdSeleccionado();

            if (id == null)
            {
                MessageBox.Show(
                    "Select a user first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // ----------------------------------------------------------
            // No puede desactivar su propia cuenta.
            // ----------------------------------------------------------
            if (id == Session.UsuarioLogueado.Id)
            {
                MessageBox.Show(
                    "You cannot deactivate your own account.",
                    "Action Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // ----------------------------------------------------------
            // Confirmación personalizada
            // ----------------------------------------------------------
            using (DELETE confirmacion =
                   new DELETE())
            {
                if (confirmacion.ShowDialog()
                    != DialogResult.OK)
                {
                    return;
                }
            }

            // ----------------------------------------------------------
            // UPDATE
            // ----------------------------------------------------------
            bool exito =
                UsersDAO.DesactivarUsuario(
                    id.Value);

            if (!exito)
            {
                MessageBox.Show(
                    "The user could not be deactivated.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show(
                "User deactivated successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarGrid();
        }

        // ==============================================================
        // ADMINISTRATORS - REACTIVATE
        // ==============================================================
        private void ucc_reactivate_CheckedChanged(object sender,EventArgs e)
        {
            if (!ucc_reactivate.Checked)
                return;

            // ----------------------------------------------------------
            // Solo SUPER_ADMIN
            // ----------------------------------------------------------

            if (!PuedeReactivarUsuarios())
            {
                MessageBox.Show(
                    "You do not have permission to reactivate users.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                ucc_reactivate.Checked = false;
                return;
            }

            int? id =
                ObtenerIdSeleccionado();

            if (id == null)
            {
                MessageBox.Show(
                    "Select a user first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                ucc_reactivate.Checked = false;
                return;
            }

            // ----------------------------------------------------------
            // Confirmación
            // ----------------------------------------------------------
            DialogResult confirmacion =
                MessageBox.Show(
                    "Activate user?",
                    "Activate",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
            {
                ucc_reactivate.Checked = false;
                return;
            }

            // ----------------------------------------------------------
            // UPDATE
            // ----------------------------------------------------------
            bool activado =
                UsersDAO.ActivarUsuario(
                    id.Value);

            if (activado)
            {
                MessageBox.Show(
                    "User re-activated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ucc_reactivate.Checked = false;

                CargarGrid();
            }
            else
            {
                MessageBox.Show(
                    "The selected user is already active.",
                    "User Already Active",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ucc_reactivate.Checked = false;
            }
        }

        // ==============================================================
        // OTROS CATÁLOGOS
        // ==============================================================
        private void AgregarNuevo()
        {
            // Pendiente de implementar.
        }

        private void EditarSeleccionado()
        {
            // Pendiente de implementar.
        }

        private void EliminarSeleccionado()
        {
            // Pendiente de implementar.
        }

        // ==============================================================
        // PAYROLL DRAFTS
        // ==============================================================
        private void GenerarPeriodo()
        {
            PERIOD PD = new PERIOD();
            PD.Show();
        }

        private void ProcesarTodo()
        {
            // Pendiente de implementar.
        }

        private void EditarBorrador()
        {
            // Pendiente de implementar.
        }

        // ==============================================================
        // EVENTOS DEL USER CONTROL
        // ==============================================================
        private void UC_Concepts_Load(object sender,EventArgs e) { }
        private void uC_Toolbar1_Load(object sender,EventArgs e){}
        private void ucc_canedit_CheckedChanged(object sender,EventArgs e) { }
    }
}