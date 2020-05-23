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
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void ventasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ventasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSet);

        }

        private void ventasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ventasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSet);

        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBDataSet1.tipospagos' Puede moverla o quitarla según sea necesario.
            this.tipospagosTableAdapter.Filltipopago(this.dBDataSet1.tipospagos);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSet.detalleventas' Puede moverla o quitarla según sea necesario.
            this.detalleventasTableAdapter.Fillventasclientes(this.dBDataSet.detalleventas);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.dBDataSet.productos);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSet.categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.dBDataSet.categorias);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.dBDataSet.usuarios);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSet.ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fillventa(this.dBDataSet.ventas);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSet.facturav' Puede moverla o quitarla según sea necesario.
            this.facturavTableAdapter.Fillfacturav(this.dBDataSet.facturav);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSet.ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fillventa(this.dBDataSet.ventas);

            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet.ventas' Puede moverla o quitarla según sea necesario.
                this.ventasTableAdapter.Fillventa(this.dBDataSet.ventas);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            totalizar();
        }
        private void totalizar()
        {
            int nfilas = 0;
            double cantidad = 0, precio = 0, suma = 0, /*iva = 0,*/ total = 0;
            nfilas = detalleventasDataGridView.RowCount;
            DataGridViewRow fila = new DataGridViewRow();
           // for (int i = 0; i < nfilas; i++)
           // {
                //fila = detalleventasDataGridView.Rows[i];
                //cantidad = double.Parse(fila.Cells["cantidad"].Value.ToString());//
                //desc = int.Parse(fila.Cells["descuento"].Value.ToString());
              //  precio = double.Parse(fila.Cells["precio"].Value.ToString());

                suma += cantidad * precio ;
            //}//
            total = suma;
            /* iva = int.Parse(tipodocumentoComboBox.SelectedValue.ToString()) == 2 ? suma * 13 / 100 : 0;
             total = suma + iva;
             lblSumaVenta.Text = "$" + Math.Round(suma, 2);
             lblIvaVenta.Text = "$" + Math.Round(iva, 2);
             lblTotalVenta.Text = "$" + Math.Round(total, 2);*/
            txttotal.Text = "$" + Math.Round(total);
            lblregistroxden.Text = ventasBindingSource.Position + 1 + " de " + ventasBindingSource.Count;
        }

        private void detalleventasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ventasBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            this.Validate();
            this.ventasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSet);
        }
    }
}
