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
    public partial class Fproductos : Form
    {
        ConexionDB objConexion = new ConexionDB();
        int posicion = 0;

        string accion="Nuevo";
        DataTable tblp = new DataTable();
        public Fproductos()
        {
            InitializeComponent();
        }
        void ActualizarDs()
        {
            tblp = objConexion.Obtener_datos().Tables["panes"];
            tblp.PrimaryKey = new DataColumn[] { tblp.Columns["idpan"] };
            MostrarDatos();
        }
        void MostrarDatos()
        {
            try
            {
                lblidpan.Text = tblp.Rows[posicion].ItemArray[0].ToString();
                txtcodigo.Text = tblp.Rows[posicion].ItemArray[1].ToString();
                txtnombre.Text = tblp.Rows[posicion].ItemArray[2].ToString();
                txttipo.Text = tblp.Rows[posicion].ItemArray[3].ToString();
                txtprecio.Text = tblp.Rows[posicion].ItemArray[4].ToString();

                lblnregistros.Text = (posicion + 1) + " de " + tblp.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Panes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar_cajas();
            }
        }
        void Limpiar_cajas()
        {
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            txttipo.Text = "";
            txtprecio.Text = "";
        }
        void Controles(Boolean valor)
        {
            grbNavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnBuscar.Enabled = valor;
            grbDatospanes.Enabled = !valor;
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
                    lblidpan.Text,
                    txtcodigo.Text,
                    txtnombre.Text,
                    txtdescripcion.Text,
                    txttipo.Text,
                    txtprecio.Text,
                };

                objConexion.Mantenimiento_panes(valores, accion);
                ActualizarDs();
                posicion = tblp.Rows.Count - 1;
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
            if (MessageBox.Show("Esta seguro de elimina a " + txtnombre.Text, "Registro de Panes",
              MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidpan.Text };
                objConexion.Mantenimiento_panes(valores, "eliminar");

                ActualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                MostrarDatos();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Fbusquedaproductos frmBusquedapanes = new Fbusquedaproductos();
            frmBusquedapanes.ShowDialog();

            if (frmBusquedapanes._idpan > 0)
            {
                posicion = tblp.Rows.IndexOf(tblp.Rows.Find(frmBusquedapanes._idpan));
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
