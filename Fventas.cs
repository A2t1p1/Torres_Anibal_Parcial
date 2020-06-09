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
    public partial class Fventas : Form
    {
        public Fventas()
        {
            InitializeComponent();
        }

        private void ventasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ventasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSetventas);

        }

        private void Fventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBDataSetventas.tipodocumento' Puede moverla o quitarla según sea necesario.
            this.tipodocumentoTableAdapter.Fill(this.dBDataSetventas.tipodocumento);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSetventas.tipospagos' Puede moverla o quitarla según sea necesario.
            this.tipospagosTableAdapter.Fill(this.dBDataSetventas.tipospagos);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSetventas.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.dBDataSetventas.usuarios);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSetventas.detallesventas' Puede moverla o quitarla según sea necesario.
            this.detallesventasTableAdapter.Fill(this.dBDataSetventas.detallesventas);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSetventas.ventas' Puede moverla o quitarla según sea necesario.
            try
            {
                this.ventasTableAdapter.Fill(this.dBDataSetventas.ventas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            totalizar();
        }

        private void ventasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ventasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSetventas);

        }

        private void totalizar()
        {
            int desc = 0, nfilas = 0;
            double cantidad = 0, precio = 0, suma = 0, iva = 0, total = 0;
            nfilas = detallesventasDataGridView.RowCount;
            DataGridViewRow fila = new DataGridViewRow();
            for (int i = 0; i < nfilas; i++)
            {
                fila = detallesventasDataGridView.Rows[i];
                cantidad = double.Parse(fila.Cells["cantidad"].Value.ToString());
                desc = int.Parse(fila.Cells["descuento"].Value.ToString());
                precio = double.Parse(fila.Cells["precio"].Value.ToString());

                suma += cantidad * precio * (1 - desc / 100);
            }
            iva = int.Parse(idtipoComboBox.SelectedValue.ToString()) == 2 ? suma * 13 / 100 : 0;
            total = suma + iva;
            lblSumaVenta.Text = "$" + Math.Round(suma, 2);
            lblIvaVenta.Text = "$" + Math.Round(iva, 2);
            lblTotalVenta.Text = "$" + Math.Round(total, 2);

            lblregistroxden.Text = ventasBindingSource.Position + 1 + " de " + ventasBindingSource.Count;
        }
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MoveFirst();
            totalizar();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MovePrevious();
            totalizar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MovePrevious();
            totalizar();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MoveNext();
            totalizar();
        }

        private void ventasBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.ventasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSetventas);

        }
    }
}
