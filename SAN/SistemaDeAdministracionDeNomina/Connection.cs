using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;//Hacer conexión con SQL
using System.Windows.Forms;

namespace SistemaDeAdministracionDeNomina
{
    class Connection
    {
        public static SqlConnection ObtainConnection()
        {
            //                                                                                                       El nombre de la base / Mi computadora
            SqlConnection connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=PayrollDB;Data Source=MEANMACHINE\\SQLEXPRESS");
            connection.Open();
          
            return connection;
        }
    }
}
