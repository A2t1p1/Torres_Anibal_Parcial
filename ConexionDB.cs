using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Torres_Anibal_Parcial
{
    class ConexionDB
    {
        SqlConnection miConexion = new SqlConnection();
        SqlCommand comandosSQL = new SqlCommand();
        SqlDataAdapter miAdaptadorDatos = new SqlDataAdapter();

        DataSet ds = new DataSet();

        public ConexionDB()
        {
            String cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SistemaDB.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadena;
            miConexion.Open();
        }
        public DataSet Obtener_datos()
        {
            ds.Clear();
            comandosSQL.Connection = miConexion;

            comandosSQL.CommandText = "select * from clientes";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "clientes");

            comandosSQL.CommandText = "select * from empleados";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "empleados");

            comandosSQL.CommandText = "select * from proveedores";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "proveedores");

            comandosSQL.CommandText = "select * from productos";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "productos");

            comandosSQL.CommandText = "select * from facturas";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "facturas");

            comandosSQL.CommandText = "select * from detalles";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "detalles");

            comandosSQL.CommandText = "select * from ventas";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "ventas");

            return ds;
        }
        public void Mantenimiento_clientes(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "Nuevo")
            {
                sql = "INSERT INTO clientes (codigo,nombre,apellido,direccion,dui,telefono) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'," +
                    "'" + datos[6] + "'"  +
                    ")";
            }
            else if (accion == "Modificar")
            {
                sql = "UPDATE clientes SET " +
                    "codigo          = '" + datos[1] + "'," +
                    "nombre          = '" + datos[2] + "'," +
                    "apellido        = '" + datos[3] + "'," +
                    "direccion       = '" + datos[4] + "'," +
                    "dui             = '" + datos[5] + "'," +
                    "telefono        = '" + datos[6] + "' " +
                    "WHERE idcliente = '" + datos[0] + "'";
            }
            else if (accion == "Eliminar")
            {
                sql = "DELETE clientes FROM clientes WHERE idcliente='" + datos[0] + "'";
            }
            ProcesarSQL(sql);
        }
        public void Mantenimiento_empleados(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "Nuevo")
            {
                sql = "INSERT INTO empleados (codigo,nombre,apellido,direccion,dui,telefono,salario) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'," +
                    "'" + datos[6] + "'," +
                    "'" + datos[7] + "'" +
                    ")";
            }
            else if (accion == "Modificar")
            {
                sql = "UPDATE empleados SET " +
                    "codigo          = '" + datos[1] + "'," +
                    "nombre          = '" + datos[2] + "'," +
                    "apellido        = '" + datos[3] + "'," +
                    "direccion       = '" + datos[4] + "'," +
                    "dui             = '" + datos[5] + "'," +
                    "telefono        = '" + datos[6] + "'," +
                    "salario         = '" + datos[6] + "' " +
                    "WHERE idempleado='"  + datos[0] + "'";
            }
            else if (accion == "Eliminar")
            {
                sql = "DELETE empleados FROM empleados WHERE idempleado='" + datos[0] + "'";
            }
            ProcesarSQL(sql);
        }
        public void Mantenimiento_proveedores(string[] datos, string accion)
        {
            string sql = "";
            if (accion == "Nuevo")
            {
                sql = "insert into proveedores(codigo,nombre_proveedor,nombre_contacto,cargo_contacto,direccion,telefono,email) values(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'," +
                    "'" + datos[6] + "'," +
                    "'" + datos[7] + "'"  +
                    ")";
            }
            else if (accion == "Modificar")
            {
                sql = "update proveedores set  " +
                    "codigo =                   '" + datos[1] + "'," +
                    "nombre_proveedor =         '" + datos[2] + "'," +
                    "nombre_contacto =          '" + datos[3] + "'," +
                    "cargo_contacto=            '" + datos[4] + "'," +
                    "direccion=                 '" + datos[5] + "'," +
                    "telefono=                  '" + datos[6] + "'," +
                    "email=                     '" + datos[7] + "'" +
                    "where idproveedor =              '" + datos[0] + "'";
            }
            else if (accion == "Eliminar")
            {
                sql = "delete proveedores from proveedores where idproveedor='" + datos[0] + "'";
            }
            ProcesarSQL(sql);
        }
        void ProcesarSQL(String sql)
        {
            comandosSQL.Connection = miConexion;
            comandosSQL.CommandText = sql;
            comandosSQL.ExecuteNonQuery();
        }

    }
}