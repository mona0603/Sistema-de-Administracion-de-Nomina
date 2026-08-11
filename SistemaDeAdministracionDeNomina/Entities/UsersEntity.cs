using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAdministracionDeNomina.Entities
{
    internal class UsersEntity
    {
        //Datos de SQL
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool IsActive { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        // Conveniencia: nombre completo armado, útil para mostrar en
        // la interfaz (ej. "Hola, Juan Pérez López") sin tener que
        // concatenar los 3 campos cada vez que lo necesites.
        //public string FullName =>
        //    string.Join(" ", new[] { FirstName, MiddleName, LastName }
        //        .Where(parte => !string.IsNullOrWhiteSpace(parte)));
    }
}
