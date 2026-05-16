using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CNVenta
    {
        public static DataTable Listar()
        {
            CDVenta Datos = new CDVenta();
            return Datos.Listar();
        }

        public static string Guardar(DateTime fecha, string tipoDocumento, decimal subtotal, decimal iva,
                                     decimal total, int idcliente, int idusuario, List<CDDetalleVenta> detalles)
        {
            CDVenta Datos = new CDVenta();

            // 1. Datos que vienen del formulario
            Datos.Fecha = fecha;
            Datos.TipoDocumento = tipoDocumento;
            Datos.Subtotal = subtotal;
            Datos.Iva = iva;
            Datos.Total = total;
            Datos.Idcliente = idcliente;
            Datos.Idusuario = idusuario;
            Datos.Serie = "001";
            Datos.NumDocumento = "000001";
            Datos.Estado = "Emitida";

            // 3. Enviamos la factura y la lista de productos a la BD
            return Datos.Guardar(Datos, detalles);
        }

        public static string Editar(int idventa, DateTime fecha, string serie, string numDocumento,
                                    string tipoDocumento, decimal subtotal, decimal iva,
                                    decimal total, string estado, int idusuario, int idcliente)
        {
            CDVenta Datos = new CDVenta();
            Datos.Idventa = idventa;
            Datos.Fecha = fecha;
            Datos.Serie = serie;
            Datos.NumDocumento = numDocumento;
            Datos.TipoDocumento = tipoDocumento;
            Datos.Subtotal = subtotal;
            Datos.Iva = iva;
            Datos.Total = total;
            Datos.Estado = estado;
            Datos.Idusuario = idusuario;
            Datos.Idcliente = idcliente;

            return Datos.Editar(Datos);
        }

        public static string Eliminar(int idventa)
        {
            CDVenta Datos = new CDVenta();
            Datos.Idventa = idventa;
            return Datos.Eliminar(Datos);
        }

        public static DataTable BuscarNumDocumento(string textoBuscar)
        {
            CDVenta Datos = new CDVenta();
            Datos.Buscar = textoBuscar;
            return Datos.BuscarNumDocumento(Datos);
        }
        public static DataTable ImprimirFactura(int idventa)
        {
            CDVenta Datos = new CDVenta();
            return Datos.ImprimirFactura(idventa);
        }
        public static DataTable BuscarFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            CDVenta Datos = new CDVenta();
            return Datos.BuscarFechas(fechaInicio, fechaFin);
        }
        public static string Anular(int idventa)
        {
            CDVenta Datos = new CDVenta();
            return Datos.AnularVenta(idventa);
        }
        public static DataTable MostrarDetalle(int idventa)
        {
            CDVenta Datos = new CDVenta();
            return Datos.MostrarDetalle(idventa);
        }
    }
}