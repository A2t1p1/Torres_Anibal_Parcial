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
    public partial class Fcategoria : Form
    {
        ConexionDB objConexion = new ConexionDB();
        int posicion = 0;
        string accion = "Nuevo";
        DataTable tbl = new DataTable();
        public Fcategoria()
        {
            InitializeComponent();
            dgvdatoscategorias.DataSource = objConexion.Obtener_datos().Tables["categorias"].DefaultView;
        }
        private void Fcategoria_Load(object sender, EventArgs e)
        {
            ActualizarDB();
            MostrarDB();
        }
        public void ActualizarDB()
        {
            tbl = objConexion.Obtener_datos().Tables["categorias"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idcategoria"] };
        }
        public void MostrarDB()
        {
            lblidcat.Text = tbl.Rows[posicion].ItemArray[0].ToString();
            txtnombre.Text = tbl.Rows[posicion].ItemArray[1].ToString();

        }
        void Limpiar_cajas()
        {
            txtnombre.Text = "";
        }
        void Controles(Boolean valor)
        {
            dgvdatoscategorias.Enabled = valor;
            btnEliminar.Enabled = valor;
            txtnombre.Enabled = !valor;
        }

        private void Btnuevo_Click(object sender, EventArgs e)
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
                    lblidcat.Text,
                    txtnombre.Text,
                };

                objConexion.Mantenimiento_categoria(valores, accion);
                ActualizarDB();
                posicion = tbl.Rows.Count - 1;
                MostrarDB();

                Controles(true);

                btnNuevo.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Modificar")
            {
                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                accion = "Modificar";

                Controles(false);

                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
            }
            else
            {
                Controles(true);
                MostrarDB();

                btnNuevo.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de elimina a " + txtnombre.Text, "Registro de Categorias",
             MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidcat.Text };
                objConexion.Mantenimiento_categoria(valores, "Eliminar");

                ActualizarDB();
                posicion = posicion > 0 ? posicion - 1 : 0;
                MostrarDB();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Fmenu cambio = new Fmenu();
            this.Hide();
            cambio.ShowDialog();
            this.Close();
        }
    }
}
