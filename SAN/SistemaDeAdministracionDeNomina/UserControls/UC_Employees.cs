using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAdministracionDeNomina.UserControls
{
    public partial class UC_Employees : UserControl
    {
        public UC_Employees()
        {
            InitializeComponent();
            CargarComboOrdenar();
        }

        // LLenar el combobox de Sort by:
        private void CargarComboOrdenar()
        {
            uce_sortby.Items.Clear();
            uce_sortby.Items.Add("A-Z");
            uce_sortby.Items.Add("Z-A");
            uce_sortby.Items.Add("Code");
            uce_sortby.Items.Add("Hire Date");

            uce_sortby.DropDownStyle = ComboBoxStyle.DropDownList; // evita que el usuario escriba texto libre
            uce_sortby.SelectedIndex = 0; // default: A-Z

            uce_sortby.SelectedIndexChanged += (s, e) => AplicarOrden();
        }
        // Aplicar el orden seleccionado
        private void AplicarOrden()
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IUNoEmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void uC_Buttons2_Load(object sender, EventArgs e)
        {

        }

        private void uC_Buttons3_Load(object sender, EventArgs e)
        {

        }

        private void UC_Employees_Load(object sender, EventArgs e)
        {

        }
    }
}
