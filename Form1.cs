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
    public partial class Form1 : Form
    {
        Convertidor objconversion = new Convertidor();
        public Form1()
        {
            InitializeComponent();
        }
        private void Btnconvertir_Click(object sender, EventArgs e)
        {
            lblmostrar.Text = " valor " + objconversion.Convertir(cbde.SelectedIndex, cba.SelectedIndex, double.Parse(txtcantidad.Text), cbtipo.SelectedIndex) + " " + objconversion.etiquetas[cbtipo.SelectedIndex][cba.SelectedIndex];
        }
        private void Cbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {   
            cbde.Items.Clear();
            cba.Items.Clear();
            cbde.Items.AddRange(objconversion.etiquetas[cbtipo.SelectedIndex]);
            cba.Items.AddRange(objconversion.etiquetas[cbtipo.SelectedIndex]);
            lblmostrar.Text = " conversor " + objconversion.tipo[cbtipo.SelectedIndex];
            cbde.SelectedIndex = 0;
            cba.SelectedIndex = 1;
            lblmostrar.Text=" ";
            Convert.ToString(txtcantidad.Text=" ");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbtipo.Items.AddRange(objconversion.tipo);
            cbtipo.SelectedIndex = 0; 
        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
