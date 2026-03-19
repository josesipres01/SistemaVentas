using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNProveedor
    {
        public static DataTable Listar()
        {
            return new CDProveedor().Listar();
        }

        public static string Guardar(string razonsocial, string dni, string rfc, string telefono, string direccion, string estado)
        {
            CDProveedor objeto = new CDProveedor();
            objeto.nombre = razonsocial;
            objeto.Dni = dni;
            objeto.Rfc = rfc;
            objeto.Telefono = telefono;
            objeto.Direccion = direccion;
            objeto.Estado = estado;

            return objeto.Guardar(objeto);
        }

        public static string Editar(int idproveedor, string razonsocial, string dni, string rfc,
                    string telefono, string direccion, string estado)
        {
            CDProveedor objeto = new CDProveedor();
            objeto.Idproveedor = idproveedor;
            objeto.nombre = razonsocial;
            objeto.Dni = dni;
            objeto.Rfc = rfc;
            objeto.Telefono = telefono;
            objeto.Direccion = direccion;
            objeto.Estado = estado;

            return objeto.Editar(objeto);
        }



        public static string Eliminar(int idproveedor)
        {
            CDProveedor objeto = new CDProveedor();
            objeto.Idproveedor = idproveedor;

            return objeto.Eliminar(objeto);
        }

        public static DataTable BuscarRazonsocial(string textobuscar)
        {
            CDProveedor objeto = new CDProveedor();
            objeto.Buscar = textobuscar;

            return objeto.BuscarRazonsocial(objeto);
        }

        public static DataTable BuscarDni(string textobuscar)
        {
            CDProveedor objeto = new CDProveedor();
            objeto.Buscar = textobuscar;

            return objeto.BuscarDni(objeto);
        }

    }
}
