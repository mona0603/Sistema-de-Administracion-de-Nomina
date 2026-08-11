using SistemaDeAdministracionDeNomina.UserControls;
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
    public partial class DELETE : Form
    {
        public DELETE()
        {
            InitializeComponent();

            uC_confirm.Click += UC_Confirm_Click;
            uC_cancel.Click += UC_Cancel_Click;
        }

        private const string TextoConfirmacion =
            "I decided to delete this information from the system.";

        private void UC_Confirm_Click(object sender, EventArgs e)
        {
            if (dlt_text.Text.Trim() != TextoConfirmacion)
            {
                MessageBox.Show(
                    "The confirmation text is incorrect.",
                    "Invalid Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void UC_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    

        private void DELETE_Load(object sender, EventArgs e)
        {

        }

        private void uC_confirm_Load(object sender, EventArgs e)
        {

        }
    }
}
