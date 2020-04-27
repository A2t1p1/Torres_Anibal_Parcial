using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torres_Anibal_Parcial
{
    public partial class FPeliculas : Form
    {
        public FPeliculas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fmenu cambio = new Fmenu();
            this.Hide();
            cambio.ShowDialog();
            this.Close();
        }
    }
}
