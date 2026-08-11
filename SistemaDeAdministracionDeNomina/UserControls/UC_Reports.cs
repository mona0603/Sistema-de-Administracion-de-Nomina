using SistemaDeAdministracionDeNomina.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAdministracionDeNomina.UserControls
{
    public partial class UC_Reports : UserControl
    {
        // Aquí necesitamos ReportType, el enum específico de reportes.
        private ReportType _tipo;

        public UC_Reports()
        {
            InitializeComponent();
            CargarComboOrdenar();
        }

        private void UC_Reports_Load(object sender, EventArgs e)
        {
        }

        // El tipo de retorno debe ser UC_Reports (esta misma clase),
        // no UC_Concepts — "return this" tiene que coincidir con el tipo
        // declarado del método.
        public UC_Reports Configurar(ReportType tipo)
        {
            _tipo = tipo;
            CargarReporte();
            return this;
        }

        // --------------------------------------------------------------
        // Trae y muestra los datos del reporte correspondiente según
        // _tipo. Placeholder por ahora — pendiente de conectar a SQL
        // (cuando lleguemos a esa parte del proyecto).
        // --------------------------------------------------------------
        private void CargarReporte()
        {
            switch (_tipo)
            {
                case ReportType.EmployeeReport:
                    // TODO: cargar reporte de empleados
                    break;
                case ReportType.GeneralPayroll:
                    // TODO: cargar reporte general de nómina
                    break;
                case ReportType.Headcounter:
                    // TODO: cargar reporte de headcount
                    break;
                case ReportType.Payroll:
                    // TODO: cargar reporte de nómina
                    break;
            }
        }

        // LLenar el combobox de Sort by:
        private void CargarComboOrdenar()
        {
            ucr_sortby.Items.Clear();
            ucr_sortby.DropDownStyle = ComboBoxStyle.DropDownList;

            switch (_tipo)
            {
                case ReportType.EmployeeReport:
                    ucr_sortby.Items.Add("A-Z");
                    ucr_sortby.Items.Add("Z-A");
                    ucr_sortby.Items.Add("Code");
                    ucr_sortby.Items.Add("Active");
                    ucr_sortby.Items.Add("Inactive");
                    break;

                case ReportType.Headcounter:
                    ucr_sortby.Items.Add("A-Z");
                    ucr_sortby.Items.Add("Z-A");
                    ucr_sortby.Items.Add("Positions");
                    ucr_sortby.Items.Add("Departments");
                    ucr_sortby.Items.Add("Active");
                    ucr_sortby.Items.Add("Inactive");
                    break;

                case ReportType.Payroll:
                case ReportType.GeneralPayroll:
                    ucr_sortby.Items.Add("A-Z");
                    ucr_sortby.Items.Add("Z-A");
                    ucr_sortby.Items.Add("Code");
                    ucr_sortby.Items.Add("Draft");
                    ucr_sortby.Items.Add("Ready");
                    break;

                case ReportType.Administrators:
                    ucr_sortby.Items.Add("A-Z");
                    ucr_sortby.Items.Add("Z-A");
                    ucr_sortby.Items.Add("Active");
                    ucr_sortby.Items.Add("Inactive");
                    break;

                default:
                    ucr_sortby.Items.Add("A-Z");
                    ucr_sortby.Items.Add("Z-A");
                    break;
            }

            ucr_sortby.SelectedIndexChanged -= SortBy_SelectedIndexChanged; // evita suscripciones duplicadas si Configurar() se llama más de una vez
            ucr_sortby.SelectedIndexChanged += SortBy_SelectedIndexChanged;

            if (ucr_sortby.Items.Count > 0)
                ucr_sortby.SelectedIndex = 0;
        }

        private void SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarOrden();
        }
        private void AplicarOrden()
        {
            //if (!(ucc_data.DataSource is DataTable tabla))
            //    return; // el grid aún no tiene datos cargados (pendiente CargarGrid)

            //string ordenamiento;

            //switch (ucc_sortby.SelectedItem?.ToString())
            //{
            //    case "A-Z":
            //        ordenamiento = "Nombre ASC"; // TODO: ajustar al nombre real de columna
            //        break;
            //    case "Z-A":
            //        ordenamiento = "Nombre DESC";
            //        break;
            //    case "Código":
            //        ordenamiento = "Codigo ASC";
            //        break;
            //    case "Calcular por":
            //        ordenamiento = "TipoCalculo ASC";
            //        break;
            //    case "Fecha (más reciente)":
            //        ordenamiento = "Fecha DESC";
            //        break;
            //    case "Fecha (más antigua)":
            //        ordenamiento = "Fecha ASC";
            //        break;
            //    default:
            //        return;
            //}

            //tabla.DefaultView.Sort = ordenamiento;
        }
    }
}