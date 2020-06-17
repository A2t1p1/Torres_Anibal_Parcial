using Torres_Anibal_Parcial.DBDataSetcomprasTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Torres_Anibal_Parcial
{
    public partial class Fcompras : Form
    {
        private int _idcompra = 0;
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
            actualizar();
        }
        private void actualizar()
        {
            try
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
                this.comprasTableAdapter.Fill(this.dBDataSetcompras.compras);
                totalizar();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void totalizar()
        {
            try
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

                    suma += cantidad * precio * (1 - desc / 100);
                }
                iva = int.Parse(idtipoComboBox.SelectedValue.ToString()) == 2 ? suma * 13 / 100 : 0;
                total = suma + iva;
                lblSumacompra.Text = "$" + Math.Round(suma, 2);
                lblIvacompra.Text = "$" + Math.Round(iva, 2);
                lblTotalcompra.Text = "$" + Math.Round(total, 2);
            }
            catch (Exception e)
            {

            }

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

        private void habdes_controles(Boolean estado)
        {
            idcompraTextBox.Enabled = !estado;
            nfacturacComboBox.Enabled = !estado;
            idproveedorComboBox.Enabled = !estado;
            idtipopagoComboBox.Enabled = !estado;
            fechapagoComboBox.Enabled = !estado;
            idtipoComboBox.Enabled = !estado;

            detallescomprasDataGridView.ReadOnly = estado;
            pnlComprasGrid.Visible = !estado;

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
                comprasBindingSource.AddNew();
            }
            else
            {
                _idcompra = int.Parse(idcompraTextBox.Text);
                this.Validate();
                this.comprasBindingSource.EndEdit();

                /**
                 * Abrimos la conexion a la BD
                 */
                comprasTableAdapter.Connection.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = comprasTableAdapter.Connection;

                if (_idcompra > 0)
                {//modificando...
                    sqlCmd.CommandText = "delete from dcompra where idcompra=" + _idcompra;
                    sqlCmd.ExecuteNonQuery();
                }
                else
                {//nuevo....
                    sqlCmd.CommandText = "select ident_current('compras') + 1 AS idcompra";
                    _idcompra = int.Parse(sqlCmd.ExecuteScalar().ToString());
                }
                int nfilas = detallescomprasDataGridView.RowCount;
                string[,] dventas = new string[nfilas, 4];
                DataGridViewRow fila = new DataGridViewRow();
                for (int i = 0; i < nfilas; i++)
                {
                    fila = detallescomprasDataGridView.Rows[i];

                    dventas[i, 0] = fila.Cells["idproducto"].Value.ToString();
                    dventas[i, 1] = fila.Cells["cantidad"].Value.ToString();
                    dventas[i, 2] = fila.Cells["precio"].Value.ToString();
                    dventas[i, 3] = fila.Cells["descuento"].Value.ToString();
                }
                this.tableAdapterManager.UpdateAll(this.dBDataSetcompras);

                for (int i = 0; i < nfilas; i++)
                {
                    dcompraTableAdapter1.Insert(
                        _idcompra,
                        int.Parse(dventas[i, 0]),
                        int.Parse(dventas[i, 1]),
                       int.Parse(dventas[i,2]),
                        int.Parse(dventas[i, 3])
                    );
                }
                actualizar();
                comprasBindingSource.MoveLast();

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
                comprasBindingSource.CancelEdit();
                detallescomprasBindingSource.CancelEdit();

                habdes_controles(true);
                btnAgregar.Text = "nuevo";
                btnModificar.Text = "modificar";
            }

        }

        private void btnQuitarProductosGrid_Click(object sender, EventArgs e)
        {
            if (detallescomprasDataGridView.RowCount > 0)
            {
                detallescomprasDataGridView.Rows.Remove(detallescomprasDataGridView.CurrentRow);
            }
        }

        private void btnAgregarProductosGrid_Click(object sender, EventArgs e)
        {
            Fbusquedaproductos buscarProductos = new Fbusquedaproductos();
            buscarProductos.ShowDialog();
            if (buscarProductos._idproducto > 0)
            {
                detallescomprasBindingSource.AddNew();

                detallescomprasDataGridView.CurrentRow.Cells["idProducto"].Value = buscarProductos._idproducto;
                detallescomprasDataGridView.CurrentRow.Cells["codigo"].Value = buscarProductos._codigo;
                detallescomprasDataGridView.CurrentRow.Cells["nombrep"].Value = buscarProductos._nombrep;
                detallescomprasDataGridView.CurrentRow.Cells["cantidad"].Value = 1;
            }

        }
            private void detallescomprasDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
            {
                try
                {

                }
                catch (Exception ex)
                {
                }
            }
        }
    } 
