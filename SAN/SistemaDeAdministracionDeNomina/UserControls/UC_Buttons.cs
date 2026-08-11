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
    public partial class UC_Buttons : UserControl
    {
        public UC_Buttons()
        {
            InitializeComponent();
            ucb_icon.Click += Control_Click;
            ucb_title.Click += Control_Click;
        }

        private void Control_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void UC_Buttons_Load(object sender, EventArgs e)
        {

        }
        public string CardTitle
        {
            get => ucb_title.Text;
            set => ucb_title.Text = value;
        }
        public Image CardImage
        {
            get { return ucb_icon.Image; }
            set { ucb_icon.Image = value; }
        }
        public Color IconBackColor
        {
            get { return ucb_icon.BackColor; }
            set { ucb_icon.BackColor = value; }
        }
    }
}
