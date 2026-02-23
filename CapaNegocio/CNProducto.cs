using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNProducto
    {
        public static DataTable Listar()
        {
            CDProducto Datos = new CDProducto();
            return Datos.Listar();
        }


        public static string Guardar(string codigo, string nombre, string descripcion,
                                     DateTime fingreso, DateTime fvencimiento, double pcompra,
                                     double pventa, int stock, string Estado, int idcategoria)
        {
            CDProducto Datos = new CDProducto();
            Datos.Codigo = codigo;
            Datos.Nombre = nombre;
            Datos.Descripcion = descripcion;
            Datos.Fingreso = fingreso;
            Datos.Fvencimiento = fvencimiento;
            Datos.Pcompra = pcompra;
            Datos.Pventa = pventa;
            Datos.Stock = stock;
            Datos.Estado = Estado;
            Datos.Idcategoria = idcategoria;    
            return Datos.Guardar(Datos);
        }

        public static string Editar(int idproducto, string descripcion)
        {
            CDCategoria Datos = new CDCategoria();
            Datos.IdCategoria = idproducto;
            Datos.Descripcion = descripcion;
            return Datos.Editar(Datos);

        }

        public static string Eliminar(int idcategoria)
        {
            CDCategoria Datos = new CDCategoria();
            Datos.IdCategoria = idcategoria;
            return Datos.Eliminar(Datos);
        }

        public static DataTable BuscarNombre(string textoBuscar)
        {
            CDCategoria Datos = new CDCategoria();
            Datos.Buscar = textoBuscar;
            return Datos.BuscarNombre(Datos);
        }
    }
}
