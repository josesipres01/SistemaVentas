using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
    {
        public class CDProveedor
        {
                public int Idproveedor { get; set; }
                public string razonsocial { get; set; }
                public string Dni { get; set; }
                public string Rfc { get; set; }
                public string Telefono { get; set; }
                public string Direccion { get; set; }
                public string Estado { get; set; }
                public string Buscar { get; set; }

            public DataTable Listar()
            {
                DataTable resul = new DataTable("proveedor");
                SqlConnection conexion = new SqlConnection();

                try
                {
                    conexion.ConnectionString = Conexión.Conn;
                    SqlCommand cmd = new SqlCommand("splistar_proveedor", conexion);
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

            public string Guardar(CDProveedor prov)
            {
                string res = "";
                SqlConnection conexion = new SqlConnection();
                try
                {
                    conexion.ConnectionString = Conexión.Conn;
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("spguardar_proveedor", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idproveedor", SqlDbType.Int).Direction =
                        ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@razonsocial", prov.razonsocial);
                    cmd.Parameters.AddWithValue("@dni", prov.Dni);
                    cmd.Parameters.AddWithValue("@rfc", prov.Rfc);
                    cmd.Parameters.AddWithValue("@telefono", prov.Telefono);
                    cmd.Parameters.AddWithValue("@direccion", prov.Direccion);
                    cmd.Parameters.AddWithValue("@estado", prov.Estado);

                    res = cmd.ExecuteNonQuery() == 1 ? "OK" : "no se guardaron los datos";
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

            public string Editar(CDProveedor prov)
            {
                string res = "";
                SqlConnection conexion = new SqlConnection();
                try
                {
                    conexion.ConnectionString = Conexión.Conn;
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("speditar_proveedor", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idproveedor", prov.Idproveedor);
                    cmd.Parameters.AddWithValue("@razonsocial", prov.razonsocial);
                    cmd.Parameters.AddWithValue("@dni", prov.Dni);
                    cmd.Parameters.AddWithValue("@rfc", prov.Rfc);
                    cmd.Parameters.AddWithValue("@telefono", prov.Telefono);
                    cmd.Parameters.AddWithValue("@direccion", prov.Direccion);
                    cmd.Parameters.AddWithValue("@estado", prov.Estado);

                    res = cmd.ExecuteNonQuery() == 1 ? "OK" : "no se editaron los datos";
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

            public string Eliminar(CDProveedor prov)
            {
                string res = "";
                SqlConnection conexion = new SqlConnection();
                try
                {
                    conexion.ConnectionString = Conexión.Conn;
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("speliminar_proveedor", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idproveedor", prov.Idproveedor);

                    res = cmd.ExecuteNonQuery() == 1 ? "OK" : "no se eliminaron los datos";
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

            public DataTable BuscarRazonsocial(CDProveedor prov)
            {
                DataTable resul = new DataTable("proveedor");
                SqlConnection conexion = new SqlConnection();

                try
                {
                    conexion.ConnectionString = Conexión.Conn;
                    SqlCommand cmd = new SqlCommand("spbuscar_proveedor_razonsocial", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@razonsocial", prov.Buscar);

                    SqlDataAdapter sqldat = new SqlDataAdapter(cmd);
                    sqldat.Fill(resul);
                }
                catch (Exception ex)
                {
                    resul = null;
                }
                return resul;
            }

            public DataTable BuscarDni(CDProveedor prov)
            {
                DataTable resul = new DataTable("proveedor");
                SqlConnection conexion = new SqlConnection();

                try
                {
                    conexion.ConnectionString = Conexión.Conn;
                    SqlCommand cmd = new SqlCommand("spbuscar_proveedor_dni", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@dni", prov.Buscar);

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

