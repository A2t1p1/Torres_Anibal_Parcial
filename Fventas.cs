using Torres_Anibal_Parcial.DBDataSetventasTableAdapters;
using System;
using System.Data.SqlClient;
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
        private int _idventa = 0;
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
            actualizarDS();
        }
        private void actualizarDS()
        {
            try
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
                this.ventasTableAdapter.Fill(this.dBDataSetventas.ventas);
                totalizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

        private void habdes_controles(Boolean estado)
        {
            idventaTextBox.Enabled = !estado;
            fechaventaDateTimePicker.Enabled = !estado;
            idtipoComboBox.Enabled = !estado;
            idtipopagoComboBox.Enabled = !estado;
            nfvvComboBox.Enabled = !estado;

            detallesventasDataGridView.ReadOnly = estado;
            pnlProductosGrid.Visible = !estado;

            panel2.Visible = estado;
            btnEliminar.Enabled = estado;
            btnBuscar.Enabled = estado;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (btnAgregar.Text == "nuevo")
            {
                btnAgregar.Text = "guardar";
                btnModificar.Text = "cancelar";

                habdes_controles(false);
                ventasBindingSource.AddNew();

            }
            else
            {
               _idventa = int.Parse(idventaTextBox.Text);
                this.Validate();
                this.ventasBindingSource.EndEdit();

                /**
                 * Abrimos la conexion a la BD
                 */
                ventasTableAdapter.Connection.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = ventasTableAdapter.Connection;

                if (_idventa > 0)
                {//modificando...
                    sqlCmd.CommandText = "delete from dventas where idventa=" + _idventa;
                    sqlCmd.ExecuteNonQuery();
                }
                else
                {//nuevo....
                    sqlCmd.CommandText = "select ident_current('ventas') + 1 AS idventa";
                    _idventa = int.Parse(sqlCmd.ExecuteScalar().ToString());
                }
                int nfilas = detallesventasDataGridView.RowCount;
                string[,] dventas = new string[nfilas, 6];
                DataGridViewRow fila = new DataGridViewRow();
                for (int i = 0; i < nfilas; i++)
                {
                    fila = detallesventasDataGridView.Rows[i];

                    
                    dventas[i, 0] = fila.Cells["idproducto"].Value.ToString();
                    dventas[i, 2] = fila.Cells["cantidad"].Value.ToString();
                    dventas[i, 3] = fila.Cells["precio"].Value.ToString();
                    dventas[i, 4] = fila.Cells["descuento"].Value.ToString();
                }
                this.tableAdapterManager.UpdateAll(this.dBDataSetventas);

                for (int i = 0; i < nfilas; i++)
                {

                    dventasTableAdapter11.Insert(
                        _idventa,
                        int.Parse( dventas [ i,0 ] ),
                        int.Parse( dventas [i,1 ] ),
                        decimal.Parse( dventas [i,2 ] ),
                        int.Parse( dventas [i,3 ] )
                        ) ;
                    
                }
                actualizarDS();
                ventasBindingSource.MoveLast();

                habdes_controles(true);
                btnAgregar.Text = "nuevo";
                btnModificar.Text = "modificar";
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "modificar")
            {
                btnAgregar.Text = "guardar";
                btnModificar.Text = "cancelar";

                habdes_controles(false);
            }
            else
            {
                ventasBindingSource.CancelEdit();
                detallesventasBindingSource.CancelEdit();

                habdes_controles(true);
                btnAgregar.Text = "nuevo";
                btnModificar.Text = "modificar";
            }
        }

        private void btnQuitarProductosGrid_Click(object sender, EventArgs e)
        {
            if (detallesventasDataGridView.RowCount > 0)
            {
                detallesventasDataGridView.Rows.Remove(detallesventasDataGridView.CurrentRow);
            }
        }

        private void btnAgregarProductosGrid_Click(object sender, EventArgs e)
        {
            Fbusquedaproductos buscarProductos = new Fbusquedaproductos();
            buscarProductos.ShowDialog();
            if (buscarProductos._idproducto > 0)
            {
                detallesventasBindingSource1.AddNew();

                detallesventasDataGridView.CurrentRow.Cells["idproducto"].Value = buscarProductos._idproducto;
                detallesventasDataGridView.CurrentRow.Cells["codigo"].Value = buscarProductos._codigo;
                detallesventasDataGridView.CurrentRow.Cells["nombrep"].Value = buscarProductos._nombrep;
                detallesventasDataGridView.CurrentRow.Cells["cantidad"].Value = 1;
            }   
        }
    }
}
