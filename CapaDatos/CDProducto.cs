using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class    CDProducto
    {
        public int Idproducto { get; set; }
        public string Codigo { get; set; }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fingreso { get; set; }
        public DateTime Fvencimiento { get; set; }
        public double Pcompra { get; set; }
        public double Pventa { get; set; }
        public int Stock { get; set; }
        public string Estado { get; set; }
        public int Idcategoria { get; set; }


        public string Buscar { get; set; }
    
       public DataTable Listar()
        {
            DataTable resul = new DataTable("producto");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexión.Conn;
                SqlCommand Cmd = new SqlCommand("splistar_producto", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(resul);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resul;
        }
        public string Guardar(CDProducto prod)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexión.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("spguardar_producto", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@idproducto", prod.Idproducto);
                Cmd.Parameters.AddWithValue("@codigo", prod.Codigo);
                Cmd.Parameters.AddWithValue("@nombre", prod.Nombre);
                Cmd.Parameters.AddWithValue("@descripcion", prod.Descripcion);
                Cmd.Parameters.AddWithValue("@f_ingreso", prod.Fingreso);
                Cmd.Parameters.AddWithValue("@f_vencimiento", prod.Fvencimiento);
                Cmd.Parameters.AddWithValue("@precio_compra", prod.Pcompra);
                Cmd.Parameters.AddWithValue("@precio_venta", prod.Pventa);
                Cmd.Parameters.AddWithValue("stock", prod.Stock);
                Cmd.Parameters.AddWithValue("estado", prod.Estado);
                Cmd.Parameters.AddWithValue("idcategoria", prod.Idcategoria);



                resul = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el registro";
            }
            catch (Exception ex)
            {
                resul = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resul;
        }

        public string Editar(CDProducto prod)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("speditar_producto", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@idproducto", prod.Idproducto);
                Cmd.Parameters.AddWithValue("@codigo", prod.Codigo);
                Cmd.Parameters.AddWithValue("@nombre", prod.Nombre);
                Cmd.Parameters.AddWithValue("@descripcion", prod.Descripcion);
                Cmd.Parameters.AddWithValue("@f_ingreso", prod.Fingreso);
                Cmd.Parameters.AddWithValue("@f_vencimiento", prod.Fvencimiento);
                Cmd.Parameters.AddWithValue("@precio_compra", prod.Pcompra);
                Cmd.Parameters.AddWithValue("@precio_venta", prod.Pventa);
                Cmd.Parameters.AddWithValue("stock", prod.Stock);
                Cmd.Parameters.AddWithValue("estado", prod.Estado);
                Cmd.Parameters.AddWithValue("idcategoria", prod.Idcategoria);

                resul = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
            }
            catch (Exception ex)
            {
                resul = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resul;
        }

        public string Eliminar(CDProducto prod)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("speliminar_producto", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@idcategoria", prod.Idproducto);

                resul = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                resul = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resul;
        }
        public DataTable BuscarNombre(CDProducto prod)
        {
            DataTable resul = new DataTable("producto");
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                SqlCommand Cmd = new SqlCommand("spbuscar_producto_nombre", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@nombre", prod.Buscar);
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(resul);
            }
            catch (Exception ex)
            {
                resul = null;
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resul;
        }
        public DataTable BuscarCodigo(CDProducto prod)
        {
            DataTable resul = new DataTable("producto");
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                SqlCommand Cmd = new SqlCommand("spbuscar_producto_codigo", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@codigo", prod.Buscar);
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(resul);
            }
            catch (Exception ex)
            {
                resul = null;
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resul;
        }

    }
}
