using System;
using System.Data;
using System.Data.SqlClient;
using SistemaDeAdministracionDeNomina.Design;

namespace SistemaDeAdministracionDeNomina.DAO
{
    class ConceptsDAO
    {
        // --------------------------------------------------------------
        // Trae los datos del catálogo correspondiente según ConceptType.
        // Cada case usa los nombres reales de columna de Nomina.sql.
        // --------------------------------------------------------------
        public static DataTable ObtenerDatos(ConceptType tipo, int? usuarioActualId = null)
        {
            string query = null;

            switch (tipo)
            {
                //case ConceptType.Departments:
                //    query = @"SELECT D_ID AS ID, D_Code AS Code, D_Name AS Name,
                //                     P_Description AS Description, D_IsActive AS IsActive
                //              FROM Departments";
                //    break;

                //case ConceptType.Positions:
                //    query = @"SELECT P_ID AS ID, P_Code AS Code, P_Name AS Name,
                //                     P_Description AS Description, P_IsActive AS IsActive
                //              FROM Positions";
                //    break;

                //case ConceptType.Banks:
                //    query = @"SELECT B_ID AS ID, B_BankCode AS Code, B_Name AS Name,
                //                     B_IsActive AS IsActive
                //              FROM Banks";
                //    break;

                //case ConceptType.Perceptions:
                //    query = @"SELECT PERC_ID AS ID, PERC_Code AS Code, PERC_Name AS Name,
                //                     PERC_Description AS Description, PERC_IsSystem AS IsSystem,
                //                     PERC_IsActive AS IsActive
                //              FROM Perceptions";
                //    break;

                //case ConceptType.Deductions:
                //    query = @"SELECT DED_ID AS ID, DED_Code AS Code, DED_Name AS Name,
                //                     DED_Description AS Description, DED_IsSystem AS IsSystem,
                //                     DED_IsActive AS IsActive
                //              FROM Deductions";
                //    break;

                case ConceptType.Administrators:
                    query = @"SELECT U.U_ID AS ID, 
                             U.U_Username AS Username,
                             U.U_FirstName AS FirstName, 
                             U.U_LastName AS LastName,
                             R.R_Name AS Role, 
                             U.U_R_ID AS RoleId,
                             U.U_IsActive AS IsActive, 
                             U.U_CreatedBy AS CreatedBy
                      FROM Users U
                      INNER JOIN Roles R ON R.R_ID = U.U_R_ID
                      WHERE U.U_ID <> @UsuarioActualId";
                    break;
                //default:
                //    // Para los demás tipos no necesitamos otro parámetro.
                //    return ObtenerDatos(tipo);
            }

            // Si ningún case coincidió (ConceptType nuevo que aún no tiene query),
            // regresamos una tabla vacía en vez de mandar un SELECT inválido a SQL Server
            if (query == null)
                return new DataTable();

            using (SqlConnection cn = Connection.ObtainConnection())
            using (SqlCommand cmd = new SqlCommand(query, cn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                if (tipo == ConceptType.Administrators && usuarioActualId.HasValue)
                {
                    cmd.Parameters.Add("@UsuarioActualId", SqlDbType.Int)
                                  .Value = usuarioActualId.Value;
                }

                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                return tabla;
            }
        }
    }
}