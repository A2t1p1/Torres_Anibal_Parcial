using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

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
            string cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadena;
            miConexion.Open();

           parametrizacion();
        }
        
        private void parametrizacion()
        {
            comandosSQL.Parameters.Add("@idu", SqlDbType.Int).Value = 0;
            comandosSQL.Parameters.Add("@ide", SqlDbType.Int).Value = 0;
            comandosSQL.Parameters.Add("@idp", SqlDbType.Int).Value = 0;
            comandosSQL.Parameters.Add("@idprov",SqlDbType.Int).Value=0;
            comandosSQL.Parameters.Add("@idca", SqlDbType.Int).Value =0;
            comandosSQL.Parameters.Add("@idpa", SqlDbType.Int).Value =0;
            comandosSQL.Parameters.Add("@cod", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@nom", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@ape", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@dir", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@dui", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@tel", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@tele", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@sa", SqlDbType.Char).Value =  "";
            comandosSQL.Parameters.Add("@car", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@em", SqlDbType.Char).Value =  "";
            comandosSQL.Parameters.Add("@nomPro",SqlDbType.Char).Value =  "";
            comandosSQL.Parameters.Add("@nomCont", SqlDbType.Char).Value ="";
            comandosSQL.Parameters.Add("@des", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@pre", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@tipa", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@fch", SqlDbType.Char).Value="";
            comandosSQL.Parameters.Add("@cate", SqlDbType.Char).Value = "";
        }
        public DataSet Obtener_datos()
        {
            ds.Clear();
            comandosSQL.Connection = miConexion;

            comandosSQL.CommandText = "select * from usuarios";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "usuarios");

            comandosSQL.CommandText = "select * from empleados";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "empleados");

            comandosSQL.CommandText = "select * from proveedores";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "proveedores");

            comandosSQL.CommandText = "select * from productos";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "productos");

            comandosSQL.CommandText = "select * from categorias";
                //"productos.nombre,productos.codigo,categorias.categoria,productos.descripcion,productos.precio from categorias inner join productos on  (productos.idproducto=categorias.idcategoria)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "categorias");

            comandosSQL.CommandText = "select  * from pagos";
                //"empleados.codigo,empleados.nombre,empleados.apellido,pagos.cargo,empleados.direccion,empleados.dui,empleados.telefono,empleados.salario,pagos.tipopago,pagos.fechap from empleados inner join pagos on (pagos.idpago=empleados.idempleado)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "pagos");

            return ds;
        }
       
        public void Mantenimiento_usuarios(String[] datos, String accion)
        {
            
            String sql = "";
            if (accion == "Nuevo")
            {
                sql = "INSERT INTO usuarios (codigo,nombre,direccion,dui,telefono) VALUES(@cod, @nom, @dir, @dui, @tele)";
            }
            else if (accion == "Modificar")
            {
                sql = "UPDATE usuarios SET "      +
                        "codigo          = @cod," +
                        "nombre          = @nom," +

                        "direccion       = @dir," +
                        "dui             = @tel," +
                        "telefono        = @dui "  +
                        "where idusuario = @idu";
            }
            else if (accion == "Eliminar")
            {
                sql = "DELETE usuarios FROM usuarios WHERE idusuario=@idu";
            }
            if (datos[0] == "")
            {
                comandosSQL.Parameters["@idu"].Value = 0;
                comandosSQL.Parameters["@cod"].Value = datos[1];  //borrar posiblemente 
                comandosSQL.Parameters["@nom"].Value = datos[2];
    
                comandosSQL.Parameters["@dir"].Value = datos[3];
                comandosSQL.Parameters["@tel"].Value = datos[4];
                comandosSQL.Parameters["@dui"].Value = datos[5];
            }
            else
            {
                comandosSQL.Parameters["@idu"].Value = datos[0];
                if (accion != "Eliminar")
                {
                    comandosSQL.Parameters["@cod"].Value = datos[1];
                    comandosSQL.Parameters["@nom"].Value = datos[2];
            
                    comandosSQL.Parameters["@dir"].Value = datos[3];
                    comandosSQL.Parameters["@tel"].Value = datos[4];
                    comandosSQL.Parameters["@dui"].Value = datos[5];
                }
            }

            ProcesarSQL(sql);
        }
        public void Mantenimiento_empleados(String[] datos, String accion)
        { 
            String sql = "";
            if (accion == "Nuevo")
            {
                sql = "INSERT INTO empleados (codigo,nombre,apellido,direccion,dui,telefono,salario) VALUES(@cod, @nom, @ape, @dir, @dui, @tel, @sa)";  
            }
            else if (accion == "Modificar")
            {
                sql = "UPDATE empleados SET " +
                    "codigo          = @cod," +
                    "nombre          = @nom," +
                    "apellido        = @ape," +
                    "direccion       = @dir," +
                    "dui             = @dui," +
                    "telefono        = @tel," +
                    "salario         = @sa " +
                    "WHERE idempleado= @ide";
            }
            else if (accion == "Eliminar")
            {
                sql = "DELETE empleados FROM empleados WHERE idempleado=@ide";
            }
            if (datos[0] == "")
            {
                comandosSQL.Parameters["@ide"].Value = 0;
                comandosSQL.Parameters["@cod"].Value = datos[1];  // supuesta solucion 
                comandosSQL.Parameters["@nom"].Value = datos[2];
                comandosSQL.Parameters["@ape"].Value = datos[3];
                comandosSQL.Parameters["@dir"].Value = datos[4];
                comandosSQL.Parameters["@dui"].Value = datos[5];
                comandosSQL.Parameters["@tel"].Value = datos[6];
                comandosSQL.Parameters["@sa"].Value = datos[7];
            }
            // llega hasta aqui
            else    // este es necesario 
            {
                comandosSQL.Parameters["@ide"].Value = datos[0];
                if (accion != "Eliminar")

                {
                    comandosSQL.Parameters["@cod"].Value = datos[1];
                    comandosSQL.Parameters["@nom"].Value = datos[2];
                    comandosSQL.Parameters["@ape"].Value = datos[3];
                    comandosSQL.Parameters["@dir"].Value = datos[4];
                    comandosSQL.Parameters["@dui"].Value = datos[5];
                    comandosSQL.Parameters["@tel"].Value = datos[6];
                    comandosSQL.Parameters["@sa"].Value = datos[7];
                }
            }
            ProcesarSQL(sql);
        }
    public void Mantenimiento_proveedores(string[] datos, string accion)
        {
            string sql = "";
            if (accion == "Nuevo")
            {
                sql = "insert into proveedores(codigo,nombrep,nombrec,cargoc,direccion,telefono,email) values( @cod, @nomPro, @nomCont, @car, @dir, @tel, @em) ";
            }
            else if (accion == "Modificar")
            {
                sql = "update proveedores set  " +
                  "codigo         = @cod, " +
                    "nombrep        = @nomPro, " +
                    "nombrec        = @nomCont, " +
                    "cargoc         = @car, " +
                    "direccion      = @dir, " +
                    "telefono       = @tel, " +
                    "email          = @em  " +
                    "where idproveedor = @idprov";
            }
            else if (accion == "Eliminar")
            {
                sql = "delete proveedores from proveedores where idproveedor=@idprov";
            }
            if (datos[0] == "")   //comienza aqui 
            {
                comandosSQL.Parameters["@idprov"].Value = 0; // este 
                comandosSQL.Parameters["@cod"].Value = datos[1];
                comandosSQL.Parameters["@nomPro"].Value = datos[2];
                comandosSQL.Parameters["@nomCont"].Value = datos[3];
                comandosSQL.Parameters["@car"].Value = datos[4];
                comandosSQL.Parameters["@dir"].Value = datos[5];
                comandosSQL.Parameters["@tel"].Value = datos[6];
                comandosSQL.Parameters["@em"].Value = datos[7];

            }
            else    //este 
            {
                comandosSQL.Parameters["@idprov"].Value = datos[0];
                if (accion != "Eliminar")
                {
                    comandosSQL.Parameters["@cod"].Value = datos[1];
                    comandosSQL.Parameters["@nomPro"].Value = datos[2];
                    comandosSQL.Parameters["@nomCont"].Value = datos[3];
                    comandosSQL.Parameters["@car"].Value = datos[4];
                    comandosSQL.Parameters["@dir"].Value = datos[5];
                    comandosSQL.Parameters["@tel"].Value = datos[6];
                    comandosSQL.Parameters["@em"].Value = datos[7];
                }
            }
            ProcesarSQL(sql);
        }
        public void Mantenimiento_productos_categorias(string[] datos, string accion)
        {
            string sql = "";
            if (accion == "Nuevo")
            {
                sql = "insert into productos(idcategoria,codigo,nombre,descripcion) values(@idca,@cod,@nom,@des) ";
            }
            else if (accion == "Modificar")
            {
                sql = "update productos set  " +
                     "idcategoria            = @idca," +
                   "codigo                 = @cod," +
                   "nombre                 = @nom," +
                   "descripcion            = @des" +
                   "where idproducto =  @idp";
            }
            else
            {
                sql = "delete productos from productos where idproducto=@idp";

            }
            if (datos[0] == "") // comienza aqui 
            {
                comandosSQL.Parameters["@idp"].Value = 0;   //sigue aqui 
                comandosSQL.Parameters["@idca"].Value = datos[1];
                comandosSQL.Parameters["@cod"].Value = datos[2];
                comandosSQL.Parameters["@nom"].Value = datos[3];
                comandosSQL.Parameters["@des"].Value = datos[4];
    
            }
            else  // este tambien 

            {
                comandosSQL.Parameters["@idp"].Value = datos[0];
                if (accion != "Eliminar")
                {
                    comandosSQL.Parameters["@idca"].Value = datos[1];
                    comandosSQL.Parameters["@cod"].Value = datos[2];
                    comandosSQL.Parameters["@nom"].Value = datos[3];
                    comandosSQL.Parameters["@des"].Value = datos[4];

                }
            }
            ProcesarSQL(sql);
        }
        public void Mantenimiento_pagos(string[] datos, string accion)
        {
            string sql = "";
            if (accion == "Nuevo")
            {
                sql = "insert into pagos(idempleado,cargo,tipopago,fechap) values(@ide,@car,@tipa,@fch)";
            }
            else if (accion == "Modificar")
            {
                sql = "update pagos set  " +
                   "idempleado =   @ide," +
                   "cargo =        @car," +
                   "tipopago=      @tipa," +
                   "fechap=        @fch " +
                   "where idpago = @idpa";
            }
            else
            {
                sql = "delete pagos from pagos where idpago=@idpa";
            }
            if (datos[0] == "")   //comienza aqui 
            {
                comandosSQL.Parameters["@idpa"].Value = 0; // este 
                comandosSQL.Parameters["@ide"].Value = datos[1];
                comandosSQL.Parameters["@car"].Value = datos[2];
                comandosSQL.Parameters["@tipa"].Value = datos[3];
                comandosSQL.Parameters["@fch"].Value = datos[4];
            }
            else    //este 
            {

                comandosSQL.Parameters["@idpa"].Value = datos[0];
                if (accion != "Eliminar")
                {
                    comandosSQL.Parameters["@ide"].Value = datos[1];
                    comandosSQL.Parameters["@car"].Value = datos[2];
                    comandosSQL.Parameters["@tipa"].Value = datos[3];
                    comandosSQL.Parameters["@fch"].Value = datos[4];
                }
            }
            ProcesarSQL(sql);
        }
        public void Mantenimiento_categoria(string[] datos, string accion)
        {
            string sql = "";
            if (accion == "Nuevo")
            {
                sql = "insert into categorias(categoria) values(@cate)";
            }
            else if (accion == "Modificar")
            {
                sql = "update categorias set  " + 
                   "categoria=        @cate" +
                   "where idcategoria = @idca";
            }
            else
            {
                sql = "delete categorias from categorias where idcategoria=@idca";
            }
            if (datos[0] == "")   //comienza aqui 
            {
                comandosSQL.Parameters["@idca"].Value = 0; // este 
                comandosSQL.Parameters["@cate"].Value = datos[1];
            }
            else    //este 
            {
                comandosSQL.Parameters["@idca"].Value = datos[0];
                if (accion != "Eliminar")
                {
                    comandosSQL.Parameters["@cate"].Value = datos[1];
                }
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