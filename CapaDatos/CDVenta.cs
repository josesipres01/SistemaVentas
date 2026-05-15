using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDVenta
    {
        // Propiedades 
        public int Idventa { get; set; }
        public DateTime Fecha { get; set; }
        public string Serie { get; set; }
        public string NumDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }
        public int Idusuario { get; set; }
        public int Idcliente { get; set; }

        public string Buscar { get; set; }

        public DataTable Listar()
        {
            DataTable resul = new DataTable("venta");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexión.Conn;
                SqlCommand Cmd = new SqlCommand("splistar_venta", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(resul);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return resul;
        }

        // CORRECCIÓN: Este método ahora usa una Transacción para guardar factura y productos juntos.
        public string Guardar(CDVenta venta, List<CDDetalleVenta> detalles)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexión.Conn;
                conexion.Open();

                // INICIA LA TRANSACCIÓN
                SqlTransaction SqlTra = conexion.BeginTransaction();

                SqlCommand Cmd = new SqlCommand("spguardar_venta", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Transaction = SqlTra;

                Cmd.Parameters.AddWithValue("@idventa", venta.Idventa).Direction = ParameterDirection.Output;
                Cmd.Parameters.AddWithValue("@fecha", venta.Fecha);
                Cmd.Parameters.AddWithValue("@serie", venta.Serie);
                Cmd.Parameters.AddWithValue("@num_documento", venta.NumDocumento);
                Cmd.Parameters.AddWithValue("@tipo_documento", venta.TipoDocumento);
                Cmd.Parameters.AddWithValue("@subtotal", venta.Subtotal);
                Cmd.Parameters.AddWithValue("@iva", venta.Iva);
                Cmd.Parameters.AddWithValue("@total", venta.Total);
                Cmd.Parameters.AddWithValue("@estado", venta.Estado);
                Cmd.Parameters.AddWithValue("@idusuario", venta.Idusuario);
                Cmd.Parameters.AddWithValue("@idcliente", venta.Idcliente);

                resul = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el registro de Venta";

                // Si la factura se guardó bien, procedemos a guardar la lista de productos
                if (resul.Equals("OK"))
                {
                    venta.Idventa = Convert.ToInt32(Cmd.Parameters["@idventa"].Value);

                    foreach (CDDetalleVenta det in detalles)
                    {
                        SqlCommand CmdDet = new SqlCommand("spguardar_detalleventa", conexion);
                        CmdDet.CommandType = CommandType.StoredProcedure;
                        CmdDet.Transaction = SqlTra;

                        CmdDet.Parameters.AddWithValue("@idventa", venta.Idventa);
                        CmdDet.Parameters.AddWithValue("@idproducto", det.Idproducto);
                        CmdDet.Parameters.AddWithValue("@cantidad", det.Cantidad);
                        CmdDet.Parameters.AddWithValue("@precio", det.Precio);
                        CmdDet.Parameters.AddWithValue("@total", det.Total);

                        resul = CmdDet.ExecuteNonQuery() > 0 ? "OK" : "Error al insertar detalles de la venta";
                        if (!resul.Equals("OK")) break;
                    }
                }

                // Confirmar o Cancelar todo
                if (resul.Equals("OK"))
                {
                    SqlTra.Commit(); // Guarda permanente en la Base de Datos
                    resul = venta.Idventa.ToString(); // convierte el "OK" en el número de ID

                }
                else
                {
                    SqlTra.Rollback(); // Borra todo si hubo un error
                }
            }
            catch (Exception ex)
            {
                resul = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return resul;
        }

        public string Editar(CDVenta venta)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("speditar_venta", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@idventa", venta.Idventa);
                Cmd.Parameters.AddWithValue("@fecha", venta.Fecha);
                Cmd.Parameters.AddWithValue("@serie", venta.Serie);
                Cmd.Parameters.AddWithValue("@num_documento", venta.NumDocumento);
                Cmd.Parameters.AddWithValue("@tipo_documento", venta.TipoDocumento);
                Cmd.Parameters.AddWithValue("@subtotal", venta.Subtotal);
                Cmd.Parameters.AddWithValue("@iva", venta.Iva);
                Cmd.Parameters.AddWithValue("@total", venta.Total);
                Cmd.Parameters.AddWithValue("@estado", venta.Estado);
                Cmd.Parameters.AddWithValue("@idusuario", venta.Idusuario);
                Cmd.Parameters.AddWithValue("@idcliente", venta.Idcliente);

                resul = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
            }
            catch (Exception ex)
            {
                resul = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return resul;
        }

        public string Eliminar(CDVenta venta)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("speliminar_venta", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@idventa", venta.Idventa);

                resul = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                resul = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return resul;
        }

        public DataTable BuscarNumDocumento(CDVenta venta)
        {
            DataTable resul = new DataTable("venta");
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                SqlCommand Cmd = new SqlCommand("spbuscar_venta_documento", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@num_documento", venta.Buscar);

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
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return resul;
        }
        public DataTable ImprimirFactura(int idventa)
        {
            DataTable dt = new DataTable("factura");
            SqlConnection conexion = new SqlConnection(Conexión.Conn);
            try
            {
                SqlCommand Cmd = new SqlCommand("sp_imprimir_factura", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idventa", idventa);
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(dt);
            }
            catch (Exception ex) { dt = null; }
            return dt;
        }
    }
}