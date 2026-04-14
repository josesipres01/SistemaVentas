using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;

namespace CapaDatos
{
    public class CDUsuario
    {
        public int Idusuario { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Acceso { get; set; }
        public string Estado { get; set; }
        public int Idempleado { get; set; }

        public string Buscar { get; set; }

        public DataTable Listar()
        {
            DataTable resul = new DataTable("usuario");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexión.Conn;
                SqlCommand cmd = new SqlCommand("splistar_usuario", conexion);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter sqldat = new SqlDataAdapter(cmd);
                sqldat.Fill(resul);
            }
            catch (Exception ex)
            {
                resul = null;
            }
            return resul;
        }

        public string Guardar(CDUsuario usu)
        {
            string res = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                conexion.Open();
                SqlCommand cmd = new SqlCommand("spguardar_usuario", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idusuario", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@usuario", usu.Usuario);
                cmd.Parameters.AddWithValue("@pass", usu.Password);
                cmd.Parameters.AddWithValue("@acceso", usu.Acceso);
                cmd.Parameters.AddWithValue("@estado", usu.Estado);
                cmd.Parameters.AddWithValue("@idempleado", usu.Idempleado);

                res = cmd.ExecuteNonQuery() == 1 ? "OK" : "no se ingreso los datos";
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return res;
        }

        public string Editar(CDUsuario usu)
        {
            string res = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                conexion.Open();
                SqlCommand cmd = new SqlCommand("speditar_usuario", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idusuario", usu.Idusuario);
                cmd.Parameters.AddWithValue("@usuario", usu.Usuario);
                cmd.Parameters.AddWithValue("@pass", usu.Password);
                cmd.Parameters.AddWithValue("@acceso", usu.Acceso);
                cmd.Parameters.AddWithValue("@estado", usu.Estado);
                cmd.Parameters.AddWithValue("@idempleado", usu.Idempleado);

                res = cmd.ExecuteNonQuery() == 1 ? "OK" : "no se edito los datos";
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return res;
        }




        public string Eliminar(CDUsuario usu)
        {
            string res = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                conexion.Open();
                SqlCommand cmd = new SqlCommand("speliminar_usuario", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idusuario", usu.Idusuario);


                res = cmd.ExecuteNonQuery() == 1 ? "OK" : "no se elimino los datos";
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return res;
        }

        public DataTable BuscarNombre(CDUsuario usu)
        {
            DataTable resul = new DataTable("usuario");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexión.Conn;
                SqlCommand cmd = new SqlCommand("spbuscar_usuario_nombre", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", usu.Buscar);

                SqlDataAdapter sqldat = new SqlDataAdapter(cmd);
                sqldat.Fill(resul);
            }
            catch (Exception ex)
            {
                resul = null;
            }
            return resul;
        }

        public DataTable BuscarNombreUsuario(CDUsuario usu)
        {
            DataTable resul = new DataTable("usuario");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexión.Conn;
                SqlCommand cmd = new SqlCommand("spbuscar_usuario_nombre_usuario", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombreusuario", usu.Buscar);

                SqlDataAdapter sqldat = new SqlDataAdapter(cmd);
                sqldat.Fill(resul);
            }
            catch (Exception ex)
            {
                resul = null;
            }
            return resul;
        }

        public DataTable Logeo(CDUsuario usu)
        {
            DataTable resul = new DataTable("usuario");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexión.Conn;
                SqlCommand cmd = new SqlCommand("spinicio_sesion", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@usuario", usu.Usuario);
                cmd.Parameters.AddWithValue("@password", usu.Password);

                SqlDataAdapter sqldat = new SqlDataAdapter(cmd);
                sqldat.Fill(resul);
            }
            catch (Exception ex)
            {
                resul = null;
            }
            return resul;
        }
    }
}
