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

        private void FormVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBDataSet.detalledeventa' Puede moverla o quitarla según sea necesario.
            this.detalledeventaTableAdapter.Filldetalleventa(this.dBDataSet.detalledeventa);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSet.tipospagos' Puede moverla o quitarla según sea necesario.
            this.tipospagosTableAdapter.Fill(this.dBDataSet.tipospagos);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.dBDataSet.productos);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.dBDataSet.usuarios);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSet.detallesventas' Puede moverla o quitarla según sea necesario.
            // this.detallesventasTableAdapter.Filldetalleventa(this.dBDataSet.detallesventas);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSet.ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.dBDataSet.ventas);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSet.tipospagos' Puede moverla o quitarla según sea necesario.
            this.tipospagosTableAdapter.Fill(this.dBDataSet.tipospagos);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.dBDataSet.productos);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.dBDataSet.usuarios);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSet.detallesventas' Puede moverla o quitarla según sea necesario.
            // this.detallesventasTableAdapter.Filldetalleventa(this.dBDataSet.detallesventas);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSet.ventas' Puede moverla o quitarla según sea necesario.
            try
            {
                this.ventasTableAdapter.Fill(this.dBDataSet.ventas);
        }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            totalizar();
        }
        private void totalizar()
        {
            int nfilas = 0;
            double cantidad = 0, precio = 0,total = 0;
            nfilas = detalledeventaDataGridView.RowCount;
            DataGridViewRow fila = new DataGridViewRow();
            for (int i = 0; i < nfilas; i++)
            {
                fila = detalledeventaDataGridView.Rows[i];
                cantidad = double.Parse(fila.Cells["cantidad"].Value.ToString());
                precio = double.Parse(fila.Cells["precio"].Value.ToString());
                total = cantidad * precio;
            }
            
            lblTotalVenta.Text = "$" + Math.Round(total, 2);

            lblregistroxden.Text = ventasBindingSource.Position + 1 + " de " + ventasBindingSource.Count;
        }

        private void ventasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ventasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSet);

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
            ventasBindingSource.MoveNext();
            totalizar();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MoveLast();
            totalizar();
        }

    }
}
