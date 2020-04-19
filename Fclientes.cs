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
    public partial class Fclientes : Form
    {
        ConexionDB objConexion = new ConexionDB();
        int posicion = 0;

        string accion = "Nuevo";
        DataTable tbl = new DataTable();
        public Fclientes()
        {
            InitializeComponent();
        }
        void ActualizarDs()
        {
            tbl = objConexion.Obtener_datos().Tables["clientes"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idCliente"] };
            MostrarDatos();
        }
        void MostrarDatos()
        {
            try
            {
                lblidcliente.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtcodigo.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtnombre.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtapellido.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtdireccion.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                txtdui.Text = tbl.Rows[posicion].ItemArray[5].ToString();
                txttelefono.Text = tbl.Rows[posicion].ItemArray[6].ToString();

                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar_cajas();
            }
        }
        void Limpiar_cajas()
        {
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtdireccion.Text = "";
            txtdui.Text = "";
            txttelefono.Text = "";
        }
        void Controles(Boolean valor)
        {
            grbNavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnBuscar.Enabled = valor;
            grbDatosClientes.Enabled = !valor;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Text == "Nuevo")
            {
                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                accion = "Nuevo";

                Limpiar_cajas();
                Controles(false);
            }
            else
            {
                String[] valores = {
                    lblidcliente.Text,
                    txtcodigo.Text,
                    txtnombre.Text,
                    txtapellido.Text,
                    txtdireccion.Text,
                    txtdui.Text,
                    txttelefono.Text,
                };

                objConexion.Mantenimiento_clientes(valores, accion);
                ActualizarDs();
                posicion = tbl.Rows.Count - 1;
                MostrarDatos();

                Controles(true);

                btnNuevo.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Modificar")
            {
                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                accion = "modificar";

                Controles(false);

                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
            }
            else
            {
                Controles(true);
                MostrarDatos();

                btnNuevo.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de elimina a " + txtnombre.Text, "Registro de Clientes",
               MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidcliente.Text };
                objConexion.Mantenimiento_clientes(valores, "eliminar");

                ActualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                MostrarDatos();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Fbusquedacliente frmBusquedaClientes = new Fbusquedacliente();
            frmBusquedaClientes.ShowDialog();

            if (frmBusquedaClientes._idcliente > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedaClientes._idcliente));
                MostrarDatos();
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Fmenu cambio = new Fmenu();
            this.Hide();
            cambio.ShowDialog();
            this.Close();
        }
    }
}
