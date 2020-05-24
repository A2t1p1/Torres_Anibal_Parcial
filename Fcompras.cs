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
    public partial class Fcompras : Form
    {
        public Fcompras()
        {
            InitializeComponent();
        }

        private void comprasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.comprasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSetcompras);

        }

        private void Fcompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBDataSetcompras.tipospagos' Puede moverla o quitarla según sea necesario.
            this.tipospagosTableAdapter.Fill(this.dBDataSetcompras.tipospagos);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSetcompras.proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.dBDataSetcompras.proveedores);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSetcompras.detallecompras' Puede moverla o quitarla según sea necesario.
            this.detallecomprasTableAdapter.Filldetallecompras(this.dBDataSetcompras.detallecompras);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSetcompras.detallecompras' Puede moverla o quitarla según sea necesario.
            this.detallecomprasTableAdapter.Filldetallecompras(this.dBDataSetcompras.detallecompras);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSetcompras.compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.Fill(this.dBDataSetcompras.compras);

        }
        private void totalizar()
        {
            int desc = 0, nfilas = 0;
            double cantidad = 0, precio = 0, /*suma = 0, iva = 0, */ total = 0;
            nfilas = detallecomprasDataGridView.RowCount;
            DataGridViewRow fila = new DataGridViewRow();
            for (int i = 0; i < nfilas; i++)
            {
                fila = detallecomprasDataGridView.Rows[i];
                cantidad = double.Parse(fila.Cells["cantidad"].Value.ToString());
              //  desc = int.Parse(fila.Cells["descuento"].Value.ToString());
                precio = double.Parse(fila.Cells["precio"].Value.ToString());

                /*suma +=*/total= cantidad * precio;
            }
           // iva = int.Parse(tipodocumentoComboBox.SelectedValue.ToString()) == 2 ? suma * 13 / 100 : 0;
           // total = suma + iva;
            //lblSumaVenta.Text = "$" + Math.Round(suma, 2);
            //lblIvaVenta.Text = "$" + Math.Round(iva, 2);
            lblTotalVenta.Text = "$" + Math.Round(total, 2);

            lblregistroxden.Text = comprasBindingSource.Position + 1 + " de " + comprasBindingSource.Count;
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            comprasBindingSource.MoveFirst();
            totalizar();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            comprasBindingSource.MovePrevious();
            totalizar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            comprasBindingSource.MoveNext();
            totalizar();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            comprasBindingSource.MoveLast();
            totalizar();
        }
    }
}
