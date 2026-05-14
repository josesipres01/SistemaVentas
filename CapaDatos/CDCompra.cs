using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDCompra
    {
        public int Idcompra { get; set; }
        public DateTime Fecha { get; set; }
        public string NumDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }
        public int Idusuario { get; set; }
        public int Idproveedor { get; set; }

        // Método con Transacción para guardar compra y detalles juntos
        public string Guardar(CDCompra compra, List<CDDetalleCompra> detalles)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexión.Conn;
                conexion.Open();

                SqlTransaction SqlTra = conexion.BeginTransaction();

                SqlCommand Cmd = new SqlCommand("spguardar_compra", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Transaction = SqlTra;

                Cmd.Parameters.AddWithValue("@idcompra", compra.Idcompra).Direction = ParameterDirection.Output;
                Cmd.Parameters.AddWithValue("@fecha", compra.Fecha);
                Cmd.Parameters.AddWithValue("@num_documento", compra.NumDocumento);
                Cmd.Parameters.AddWithValue("@tipo_documento", compra.TipoDocumento);
                Cmd.Parameters.AddWithValue("@subtotal", compra.Subtotal);
                Cmd.Parameters.AddWithValue("@iva", compra.Iva);
                Cmd.Parameters.AddWithValue("@total", compra.Total);
                Cmd.Parameters.AddWithValue("@estado", compra.Estado);
                Cmd.Parameters.AddWithValue("@idusuario", compra.Idusuario);
                Cmd.Parameters.AddWithValue("@idproveedor", compra.Idproveedor);

                resul = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el registro de Compra";

                if (resul.Equals("OK"))
                {
                    compra.Idcompra = Convert.ToInt32(Cmd.Parameters["@idcompra"].Value);

                    foreach (CDDetalleCompra det in detalles)
                    {
                        SqlCommand CmdDet = new SqlCommand("spguardar_detallecompra", conexion);
                        CmdDet.CommandType = CommandType.StoredProcedure;
                        CmdDet.Transaction = SqlTra;

                        CmdDet.Parameters.AddWithValue("@idcompra", compra.Idcompra);
                        CmdDet.Parameters.AddWithValue("@idproducto", det.Idproducto);
                        CmdDet.Parameters.AddWithValue("@cantidad", det.Cantidad);
                        CmdDet.Parameters.AddWithValue("@precio", det.Precio);
                        CmdDet.Parameters.AddWithValue("@total", det.Total);

                        resul = CmdDet.ExecuteNonQuery() > 0 ? "OK" : "Error al insertar detalles de la compra";
                        if (!resul.Equals("OK")) break;
                    }
                }

                if (resul.Equals("OK"))
                {
                    SqlTra.Commit();
                }
                else
                {
                    SqlTra.Rollback();
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
    }
}