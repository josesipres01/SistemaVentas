using System;

namespace CapaDatos
{
    public class CDDetalleCompra
    {
        public int Iddetallecompra { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public int Idcompra { get; set; }
        public int Idproducto { get; set; }
    }
}