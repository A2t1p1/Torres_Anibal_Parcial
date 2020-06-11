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
            // TODO: esta línea de código carga datos en la tabla 'dBDataSetcompras1.tipodocumento' Puede moverla o quitarla según sea necesario.
            this.tipodocumentoTableAdapter.Fill(this.dBDataSetcompras1.tipodocumento);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSetcompras.tipospagos' Puede moverla o quitarla según sea necesario.
            this.tipospagosTableAdapter.Fill(this.dBDataSetcompras.tipospagos);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSetcompras.proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.dBDataSetcompras.proveedores);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSetcompras.detallescompras' Puede moverla o quitarla según sea necesario.
            this.detallescomprasTableAdapter.Fill(this.dBDataSetcompras.detallescompras);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSetcompras.compras' Puede moverla o quitarla según sea necesario.
            try
            {
                this.comprasTableAdapter.Fill(this.dBDataSetcompras.compras);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }totalizar();
        }
        private void totalizar()
        {
            int desc = 0, nfilas = 0;
            double cantidad = 0, precio = 0, suma = 0, iva = 0, total = 0;
            nfilas = detallescomprasDataGridView.RowCount;
            DataGridViewRow fila = new DataGridViewRow();
            for (int i = 0; i < nfilas; i++)
            {
                fila = detallescomprasDataGridView.Rows[i];
                precio = double.Parse(fila.Cells["precio"].Value.ToString());
                desc = int.Parse(fila.Cells["descuento"].Value.ToString());
                cantidad = double.Parse(fila.Cells["cantidad"].Value.ToString());

                suma += cantidad * precio * (1-desc/100);
            }
            iva = int.Parse(idtipoComboBox.SelectedValue.ToString()) == 2 ? suma * 13 / 100 : 0;
            total = suma + iva;
            lblSumacompra.Text = "$" + Math.Round(suma, 2);
            lblIvacompra.Text = "$" + Math.Round(iva, 2);
            lblTotalcompra.Text = "$" + Math.Round(total, 2);
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
            comprasBindingSource.MovePrevious();
            totalizar();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            comprasBindingSource.MoveNext();
            totalizar();
        }
    }
}
