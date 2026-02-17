using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNCategoria
    {
        public static DataTable Listar()
        {
            CDCategoria Datos = new CDCategoria();
            return Datos.Listar();
        }


        public static string Guardar(string descripcion)
        {
            CDCategoria Datos = new CDCategoria();
            Datos.Descripcion = descripcion;
            return Datos.Guardar(Datos);
        }

        public static string Editar(int idcategoria, string descripcion)
        {
            CDCategoria Datos = new CDCategoria();
            Datos.IdCategoria = idcategoria;
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


