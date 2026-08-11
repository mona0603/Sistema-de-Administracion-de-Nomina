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
    public partial class UC_Toolbar : UserControl
    {
        public UC_Toolbar()
        {
            InitializeComponent();
        }

        // Limpia todos los botones del toolbar.
        public void ClearButtons()
        {
            uct_flowpanel.Controls.Clear();
        }

        // Agrega un botón al toolbar.
        public UC_Buttons AddButton(string text, Image icon, Color color, EventHandler click)
        {
            var button = CreateButton(text, icon, color);
            button.Click += click;
            uct_flowpanel.Controls.Add(button);
            return button;
        }

        // Crea un botón con el estilo del sistema.
        private UC_Buttons CreateButton(string text, Image icon, Color color)
        {
            UC_Buttons button = new UC_Buttons();
            button.CardTitle = text;
            button.CardImage = icon;
            button.IconBackColor = color;
            button.BorderStyle = BorderStyle.FixedSingle;
            return button;
        }

        private void uct_flowpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
