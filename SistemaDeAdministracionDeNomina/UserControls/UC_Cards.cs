using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAdministracionDeNomina
{
    public partial class UC_Cards : UserControl
    {
        public event EventHandler CardClicked;

        public UC_Cards()
        {
            InitializeComponent();

            // Propaga el click de los controles internos hacia afuera
            this.Click += UC_Cards_Click;
            ucc_title.Click += UC_Cards_Click;
            ucc_description.Click += UC_Cards_Click;
            ucc_icon.Click += UC_Cards_Click;
            ucc_go.Click += UC_Cards_Click;
        }

        private void UC_Cards_Click(object sender, EventArgs e)
        {
            CardClicked?.Invoke(this, e);
        }

        private void UC_Cards_Load(object sender, EventArgs e)
        {

        }

        //Manipular los labels y imagenes de este card (User control)
        public string CardTitle //Utilizar el label correctamente para poner el nombre correspondiente
        {
            get => ucc_title.Text;
            set => ucc_title.Text = value;
        }
        public string CardDescription
        {
            get => ucc_description.Text;
            set => ucc_description.Text = value;
        }
        public Image CardImage
        {
            get { return ucc_icon.Image; }
            set { ucc_icon.Image = value; }
        }
        public Image CardImageSecond
        {
            get { return ucc_go.Image; }
            set { ucc_go.Image = value; }
        }
    }
}
