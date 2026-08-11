using SistemaDeAdministracionDeNomina.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAdministracionDeNomina
{
    class SystemInitializer
    {
        //Clase para verificar si hay algún usuario (primera vez en el sistema = usuarios registrados en la base de datos)
        public static bool IsFirstRun()
        {
            return !UsersDAO.HasUsers();
        }
    }
}
