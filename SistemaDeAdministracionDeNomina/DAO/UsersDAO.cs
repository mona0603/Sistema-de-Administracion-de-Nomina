//Contraseña encriptada
using BCrypt.Net;
//Entidades
using SistemaDeAdministracionDeNomina.Entities;
using System;
using System.Collections.Generic;
//SQL
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SistemaDeAdministracionDeNomina.DAO
{
    class UsersDAO
    {
        //1.
        //Buscar usuarios si es la primera vez en el sistema (si hay registros en la base de datos)
        public static bool HasUsers()
        {
            using (SqlConnection cn = Connection.ObtainConnection())
            {
                string query = "SELECT COUNT(*) FROM Users";

                SqlCommand cmd = new SqlCommand(query, cn);

                int totalUsers = (int)cmd.ExecuteScalar();

                return totalUsers > 0;
            }
        }

        //2.
        //Insertar el SUPER_ADMIN si es que es la primera vez en el sistema
        //Credenciales iniciales: usuario y contraseña
        public static bool CreateFirstAdministrator(string username, string password)
        {
            try
            {
                using (SqlConnection cn = Connection.ObtainConnection())
                {
                    // Verificar correo
                    string checkUsername = "SELECT COUNT(*) FROM Users WHERE U_Username = @Username";

                    SqlCommand cmd = new SqlCommand(checkUsername, cn);
                    cmd.Parameters.AddWithValue("@Username", username);

                    int exists = (int)cmd.ExecuteScalar();

                    if (exists > 0)
                        return false;

                    // Obtener rol
                    string getRole = "SELECT R_ID FROM Roles WHERE R_Name = 'SUPER_ADMIN'";

                    cmd = new SqlCommand(getRole, cn);

                    int roleId = (int)cmd.ExecuteScalar();

                    // Hash
                    string hash = BCrypt.Net.BCrypt.HashPassword(password);

                    // Insert
                    string insert = @"INSERT INTO Users
                    (
                        U_R_ID,
                        U_Username,
                        U_PswrdHash,
                        U_IsActive,
                        U_CreatedBy
                    )
                    VALUES
                    (
                        @RoleId,
                        @Username,
                        @PasswordHash,
                        1,
                        NULL
                    )";

                    cmd = new SqlCommand(insert, cn);

                    cmd.Parameters.AddWithValue("@RoleId", roleId);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", hash);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException ex) //Si surge un error, se devuelve
            {
                return false;
            }
        }

        //3.
        //Verificar los datos del usuario que se va a logear en el sistema
        //Se recibe de parametro el usuario y password que el usuario escribió para ingresar al sistema
        public static UsersEntity ValidateLogin(string username, string password)
        {
            using (SqlConnection cn = Connection.ObtainConnection())
            {
                string query = @"
                SELECT
                    U.U_ID,
                    U.U_R_ID,
                    U.U_Username,
                    U.U_PswrdHash,
                    U.U_IsActive,
                    U.U_FirstName,
                    U.U_MiddleName,
                    U.U_LastName,
                    R.R_Name
                FROM Users U
                INNER JOIN Roles R ON R.R_ID = U.U_R_ID
                WHERE U.U_Username = @Username";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Username", username);

                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.Read())
                    return null;

                string hash = reader["U_PswrdHash"].ToString();

                if (!BCrypt.Net.BCrypt.Verify(password, hash))
                    return null;

                bool isActive = Convert.ToBoolean(reader["U_IsActive"]);
                if (!isActive)
                    return null; // usuario desactivado, no puede iniciar sesión aunque la contraseña sea correcta

                UsersEntity user = new UsersEntity();
                user.Id = Convert.ToInt32(reader["U_ID"]);
                user.RoleId = Convert.ToInt32(reader["U_R_ID"]);
                user.RoleName = reader["R_Name"].ToString();
                user.Username = reader["U_Username"].ToString();
                user.IsActive = isActive;
                user.FirstName = reader["U_FirstName"].ToString();
                user.MiddleName = reader["U_MiddleName"] == DBNull.Value ? null : reader["U_MiddleName"].ToString();
                user.LastName = reader["U_LastName"].ToString();

                reader.Close(); // cerrar el reader antes de correr otro comando en la misma conexión

                // UPDATE el momento de este login
                string updateLastLogin = @"
                UPDATE Users
                SET U_LastLoginAt = SYSDATETIME()
                OUTPUT INSERTED.U_LastLoginAt
                WHERE U_ID = @UserId";

                SqlCommand updateCmd = new SqlCommand(updateLastLogin, cn);
                updateCmd.Parameters.AddWithValue("@UserId", user.Id);

                object resultado = updateCmd.ExecuteScalar();
                user.LastLogin = Convert.ToDateTime(resultado);

                return user;
            }
        }

        //4.
        // Actualiza los datos de perfil de un usuario. Si nuevaPassword es
        // null, la contraseña actual NO se toca (el usuario no quiso cambiarla).
        public static bool UpdateProfile(int userId, string firstName, string middleName, string lastName, string username, string nuevaPassword)
        {
            try
            {
                using (SqlConnection cn = Connection.ObtainConnection())
                {
                    // Verificar que el nuevo username no esté en uso por OTRO usuario
                    string checkUsername = "SELECT COUNT(*) FROM Users WHERE U_Username = @Username AND U_ID <> @UserId";
                    SqlCommand checkCmd = new SqlCommand(checkUsername, cn);
                    checkCmd.Parameters.AddWithValue("@Username", username);
                    checkCmd.Parameters.AddWithValue("@UserId", userId);

                    int existe = (int)checkCmd.ExecuteScalar();
                    if (existe > 0)
                        return false; // otro usuario ya tiene ese username

                    string query;
                    SqlCommand cmd;

                    //Si se quizo cambiar la contraseña
                    if (nuevaPassword != null)
                    {
                        string hash = BCrypt.Net.BCrypt.HashPassword(nuevaPassword);

                        query = @"
                        UPDATE Users
                        SET U_FirstName = @FirstName,
                            U_MiddleName = @MiddleName,
                            U_LastName = @LastName,
                            U_Username = @Username,
                            U_PswrdHash = @PasswordHash,
                            U_UpdatedBy = @UserId,
                            U_UpdatedAt = SYSDATETIME()
                        WHERE U_ID = @UserId";

                        cmd = new SqlCommand(query, cn);
                        cmd.Parameters.AddWithValue("@PasswordHash", hash);
                    }
                    //Si no se quizo cambiar la contraseña
                    else
                    {
                        query = @"
                        UPDATE Users
                        SET U_FirstName = @FirstName,
                            U_MiddleName = @MiddleName,
                            U_LastName = @LastName,
                            U_Username = @Username,
                            U_UpdatedBy = @UserId,
                            U_UpdatedAt = SYSDATETIME()
                        WHERE U_ID = @UserId";

                        cmd = new SqlCommand(query, cn);
                    }

                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@MiddleName", (object)middleName ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        //5.
        // Verifica que la contraseña dada coincida con la actual del usuario,
        // sin necesidad de repetir toda la lógica de ValidateLogin.
        public static bool VerificarPassword(int userId, string password)
        {
            using (SqlConnection cn = Connection.ObtainConnection())
            {
                string query = "SELECT U_PswrdHash FROM Users WHERE U_ID = @UserId";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@UserId", userId);

                object resultado = cmd.ExecuteScalar();
                if (resultado == null)
                    return false;

                string hashActual = resultado.ToString();
                return BCrypt.Net.BCrypt.Verify(password, hashActual);
            }
        }

        //6.
        //Refrescar los datos en el sistema (no la base)
        public static UsersEntity ObtenerPorId(int userId)
        {
            using (SqlConnection cn = Connection.ObtainConnection())
            {
                string query = @"
                SELECT
                    U.U_ID, U.U_R_ID, U.U_Username, U.U_IsActive,
                    U.U_FirstName, U.U_MiddleName, U.U_LastName,
                    U.U_UpdatedAt, U.U_LastLoginAt,
                    R.R_Name
                FROM Users U
                INNER JOIN Roles R ON R.R_ID = U.U_R_ID
                WHERE U.U_ID = @UserId";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@UserId", userId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                        return null;

                    return new UsersEntity
                    {
                        Id = Convert.ToInt32(reader["U_ID"]),
                        RoleId = Convert.ToInt32(reader["U_R_ID"]),
                        RoleName = reader["R_Name"].ToString(),
                        Username = reader["U_Username"].ToString(),
                        IsActive = Convert.ToBoolean(reader["U_IsActive"]),
                        FirstName = reader["U_FirstName"].ToString(),
                        MiddleName = reader["U_MiddleName"] == DBNull.Value ? null : reader["U_MiddleName"].ToString(),
                        LastName = reader["U_LastName"].ToString(),
                        UpdatedAt = reader["U_UpdatedAt"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["U_UpdatedAt"]),
                        LastLogin = reader["U_LastLoginAt"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["U_LastLoginAt"])
                    };
                }
            }
        }

        //7.
        // Comprobar si ya existe un usuario con el mismo usuario, en caso de que quiera registrar uno mismo
        public static bool ExisteUsername(string username, int? excluirId = null)
        {
            using (SqlConnection cn = Connection.ObtainConnection())
            {
                string query = excluirId.HasValue
                    ? "SELECT COUNT(*) FROM Users WHERE U_Username = @Username AND U_ID <> @ExcluirId"
                    : "SELECT COUNT(*) FROM Users WHERE U_Username = @Username";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Username", username);

                if (excluirId.HasValue)
                    cmd.Parameters.AddWithValue("@ExcluirId", excluirId.Value);

                int existe = (int)cmd.ExecuteScalar();
                return existe > 0;
            }
        }

        //8.
        //Obtener el rol en base al ID del rol seleccionado
        public static int ObtenerRoleIdPorNombre(string roleName)
        {
            using (SqlConnection cn = Connection.ObtainConnection())
            {
                string query = "SELECT R_ID FROM Roles WHERE R_Name = @RoleName";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@RoleName", roleName);

                object resultado = cmd.ExecuteScalar();
                return resultado != null ? Convert.ToInt32(resultado) : 0;
            }
        }

        //9. Insertar nuevos usuarios
        public static bool CrearUsuario(string username, string password, int roleId, int creadoPorUserId)
        {
            try
            {
                using (SqlConnection cn = Connection.ObtainConnection())
                {
                    if (ExisteUsername(username))
                        return false;

                    string hash = BCrypt.Net.BCrypt.HashPassword(password);

                    string insert = @"INSERT INTO Users
                (U_R_ID, U_Username, U_PswrdHash, U_IsActive, U_CreatedBy)
                VALUES (@RoleId, @Username, @PasswordHash, 1, @CreatedBy)";

                    SqlCommand cmd = new SqlCommand(insert, cn);
                    cmd.Parameters.AddWithValue("@RoleId", roleId);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", hash);
                    cmd.Parameters.AddWithValue("@CreatedBy", creadoPorUserId);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        //10.Actualizar informacion del usuario
        public static bool ActualizarUsuario(int userId, string username, string nuevaPassword, int roleId, int actualizadoPorUserId)
        {
            try
            {
                using (SqlConnection cn = Connection.ObtainConnection())
                {
                    if (ExisteUsername(username, userId))
                        return false;

                    string query;
                    SqlCommand cmd;

                    //Si quizo cambiar la contraseña
                    if (nuevaPassword != null)
                    {
                        string hash = BCrypt.Net.BCrypt.HashPassword(nuevaPassword);

                        query = @"
                    UPDATE Users
                    SET U_Username = @Username,
                        U_PswrdHash = @PasswordHash,
                        U_R_ID = @RoleId,
                        U_UpdatedBy = @UpdatedBy,
                        U_UpdatedAt = SYSDATETIME()
                    WHERE U_ID = @UserId";

                        cmd = new SqlCommand(query, cn);
                        cmd.Parameters.AddWithValue("@PasswordHash", hash);
                    }
                    //Si NO quizo cambiar la contraseña
                    else
                    {
                        query = @"
                    UPDATE Users
                    SET U_Username = @Username,
                        U_R_ID = @RoleId,
                        U_UpdatedBy = @UpdatedBy,
                        U_UpdatedAt = SYSDATETIME()
                    WHERE U_ID = @UserId";

                        cmd = new SqlCommand(query, cn);
                    }

                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@RoleId", roleId);
                    cmd.Parameters.AddWithValue("@UpdatedBy", actualizadoPorUserId);
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        //11.Desactivar el usuario (solo es hacer update y cambiar el estado de en U_IsActive)
        public static bool DesactivarUsuario(int userId)
        {
            using (SqlConnection cn = Connection.ObtainConnection())
            {
                string query = "UPDATE Users SET U_IsActive = 0 WHERE U_ID = @UserId";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@UserId", userId);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        //12. Reactivar usuario
        public static bool ActivarUsuario(int userId)
        {
            using (SqlConnection cn = Connection.ObtainConnection())
            {
                string query = "UPDATE Users SET U_IsActive = 1 WHERE U_ID = @UserId AND U_IsActive = 0";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@UserId", userId);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}