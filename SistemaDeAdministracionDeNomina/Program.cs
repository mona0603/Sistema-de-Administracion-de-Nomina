using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//DAO y Diseño
using SistemaDeAdministracionDeNomina.DAO;
using SistemaDeAdministracionDeNomina.Design;

namespace SistemaDeAdministracionDeNomina
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Si es primera vez (no hay usuarios registrados aún):
            if (SystemInitializer.IsFirstRun())
            {
                //Entonces ejecuta:
                Application.Run(new FIRSTADMIN());
            }
            else
            {
                //Si no ejecuta:
                Application.Run(new LOGIN());
            }
        }
    }
}
