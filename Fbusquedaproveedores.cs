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
    public partial class Fbusquedaproveedores : Form
    {
        ConexionDB objConexion = new ConexionDB();
        public int _idproveedor;
        public Fbusquedaproveedores()
        {
            InitializeComponent();
        }

        private void Btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaClientes.RowCount > 0)
            {
                _idproveedor = int.Parse(grdBusquedaClientes.CurrentRow.Cells["idproveedor"].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Proveedor",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            Filtrar_datos(txtbuscar.Text);
        }
        void Filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaClientes.DataSource;
            bs.Filter = "nombre_proveedor like '%" + valor + "%'";
            bs.Filter = "nombre_contacto like '%" + valor + "%'";
            grdBusquedaClientes.DataSource = bs;
        }
    }
}
