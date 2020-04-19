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
    
    public partial class Fbusquedaproductos : Form
    {
        ConexionDB objConexion = new ConexionDB();
        public int _idproducto;
        public Fbusquedaproductos()
        {
            InitializeComponent();
        }
        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaClientes.RowCount > 0)
            {
                _idproducto = int.Parse(grdBusquedaClientes.CurrentRow.Cells["idprodcuto"].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Empleados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            Filtrar_datos(txtbuscar.Text);
        }

        void Filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaClientes.DataSource;
            bs.Filter = "nombre like '%" + valor + "%'";
            bs.Filter = "direccion like '%" + valor + "%'";
            grdBusquedaClientes.DataSource = bs;
        }
        
    }
}
