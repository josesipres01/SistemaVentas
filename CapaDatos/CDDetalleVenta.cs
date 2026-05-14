using System;

namespace CapaDatos
{
    public class CDDetalleVenta
    {
        public int Iddetalleventa { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }  
        public decimal Total { get; set; }   
        public int Idventa { get; set; }
        public int Idproducto { get; set; }
    }
}