using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNEmpleado
    {
        public static DataTable Listar()
        {
            return new CDEmpleado().Listar();
        }

        public static string Guardar(string nombre, string apellidos,
            string dni, string telefono, string direccion, string estado)
        {
            CDEmpleado objeto = new CDEmpleado();

            objeto.Nombre = nombre;
            objeto.Apellidos = apellidos;
            objeto.Dni = dni;
            objeto.Telefono = telefono;
            objeto.Direccion = direccion;
            objeto.Estado = estado;

            return objeto.Guardar(objeto);
        }

        public static string Editar(int idempleado, string nombre, string apellidos,
            string dni, string telefono, string direccion, string estado)
        {
            CDEmpleado objeto = new CDEmpleado();

            objeto.Idempleado = idempleado;
            objeto.Nombre = nombre;
            objeto.Apellidos = apellidos;
            objeto.Dni = dni;
            objeto.Telefono = telefono;
            objeto.Direccion = direccion;
            objeto.Estado = estado;

            return objeto.Editar(objeto);
        }

        public static string Eliminar(int idempleado)
        {
            CDEmpleado objeto = new CDEmpleado();

            objeto.Idempleado = idempleado;

            return objeto.Eliminar(objeto);
        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            CDEmpleado objeto = new CDEmpleado();

            objeto.Buscar = textobuscar;

            return objeto.BuscarNombre(objeto);
        }

        public static DataTable BuscarDni(string textobuscar)
        {
            CDEmpleado objeto = new CDEmpleado();

            objeto.Buscar = textobuscar;

            return objeto.BuscarDni(objeto);
        }
    }
}

