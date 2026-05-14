using CapaDatos;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CNCompra
    {
        public static string Guardar(DateTime fecha, string numDocumento, string tipoDocumento,
                                     decimal subtotal, decimal iva, decimal total,
                                     int idproveedor, int idusuario, List<CDDetalleCompra> detalles)
        {
            CDCompra Datos = new CDCompra();

            Datos.Fecha = fecha;
            Datos.NumDocumento = numDocumento;
            Datos.TipoDocumento = tipoDocumento;
            Datos.Subtotal = subtotal;
            Datos.Iva = iva;
            Datos.Total = total;
            Datos.Idproveedor = idproveedor;
            Datos.Idusuario = idusuario;

            // Dato en automático:
            Datos.Estado = "Recibida";

            return Datos.Guardar(Datos, detalles);
        }
    }
}