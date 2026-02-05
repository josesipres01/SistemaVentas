using System;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDCliente
    {
        public int Idcliente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public string Rfc { get; set; }
        public string Telefono { get; set; }
        public string Estado { get; set; }
        public string Buscar { get; set; }

        public DataTable Listar()
        {
            DataTable resul = new DataTable("Cliente");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexión.Conn;
                SqlCommand Cmd = new SqlCommand("splistar_cliente", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

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
        public string Guardar(CDCliente cli)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexión.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("spguardar_cliente", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@idcliente", SqlDbType.Int).Direction = ParameterDirection.Output;
                Cmd.Parameters.AddWithValue("@nombre", cli.Nombre);
                Cmd.Parameters.AddWithValue("@apellidos", cli.Apellidos);
                Cmd.Parameters.AddWithValue("@dni", cli.Dni);
                Cmd.Parameters.AddWithValue("@rfc", cli.Rfc);
                Cmd.Parameters.AddWithValue("@telefono", cli.Telefono);
                Cmd.Parameters.AddWithValue("@estado", cli.Estado);

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

        public string Editar(CDCliente cli)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("speditar_cliente", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@idcliente", cli.Idcliente);
                Cmd.Parameters.AddWithValue("@nombre", cli.Nombre);
                Cmd.Parameters.AddWithValue("@apellidos", cli.Apellidos);
                Cmd.Parameters.AddWithValue("@dni", cli.Dni);
                Cmd.Parameters.AddWithValue("@Rfc", cli.Rfc);
                Cmd.Parameters.AddWithValue("@telefono", cli.Telefono);
                Cmd.Parameters.AddWithValue("@estado", cli.Estado);

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

        public string Eliminar(CDCliente cli)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("speliminar_cliente", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@idcliente", cli.Idcliente);

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
        public DataTable BuscarNombre(CDCliente cli)
        {
            DataTable resul = new DataTable("Cliente");
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                SqlCommand Cmd = new SqlCommand("spbuscar_cliente_nombre", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@nombre", cli.Buscar);
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
        public DataTable BuscarDni(CDCliente cli)
        {
            DataTable resul = new DataTable("Cliente");
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                SqlCommand Cmd = new SqlCommand("spbuscar_cliente_dni", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@dni", cli.Buscar);
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