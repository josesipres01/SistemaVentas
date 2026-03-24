using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDEmpleado
    {
        public int Idempleado { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }
        public string Buscar { get; set; }

        public DataTable Listar()
        {
            DataTable resul = new DataTable("empleado");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexión.Conn;
                SqlCommand cmd = new SqlCommand("splistar_empleado", conexion);
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

        public string Guardar(CDEmpleado emp)
        {
            string res = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                conexion.Open();
                SqlCommand cmd = new SqlCommand("spguardar_empleado", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idempleado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@nombre", emp.Nombre);
                cmd.Parameters.AddWithValue("@apellidos", emp.Apellidos);
                cmd.Parameters.AddWithValue("@dni", emp.Dni);
                cmd.Parameters.AddWithValue("@telefono", emp.Telefono);
                cmd.Parameters.AddWithValue("@direccion", emp.Direccion);
                cmd.Parameters.AddWithValue("@estado", emp.Estado);

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

        public string Editar(CDEmpleado emp)
        {
            string res = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                conexion.Open();
                SqlCommand cmd = new SqlCommand("speditar_empleado", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idempleado", emp.Idempleado);
                cmd.Parameters.AddWithValue("@nombre", emp.Nombre);
                cmd.Parameters.AddWithValue("@apellidos", emp.Apellidos);
                cmd.Parameters.AddWithValue("@dni", emp.Dni);
                cmd.Parameters.AddWithValue("@telefono", emp.Telefono);
                cmd.Parameters.AddWithValue("@direccion", emp.Direccion);
                cmd.Parameters.AddWithValue("@estado", emp.Estado);

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


        public string Eliminar(CDEmpleado emp)
        {
            string res = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                conexion.Open();
                SqlCommand cmd = new SqlCommand("speliminar_empleado", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idempleado", emp.Idempleado);

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

        public DataTable BuscarNombre(CDEmpleado emp)
        {
            DataTable resul = new DataTable("empleado");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexión.Conn;
                SqlCommand cmd = new SqlCommand("spbuscar_empleado_nombre", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", emp.Buscar);

                SqlDataAdapter sqldat = new SqlDataAdapter(cmd);
                sqldat.Fill(resul);
            }
            catch (Exception ex)
            {
                resul = null;
            }
            return resul;
        }


        public DataTable BuscarDni(CDEmpleado emp)
        {
            DataTable resul = new DataTable("empleado");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexión.Conn;
                SqlCommand cmd = new SqlCommand("spbuscar_empleado_dni", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", emp.Buscar);

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
