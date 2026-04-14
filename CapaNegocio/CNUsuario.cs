using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
namespace CapaNegocio
{
    public class CNUsuario
    {
        public static DataTable Listar()
        {
            return new CDUsuario().Listar();
        }

        public static string Guardar(string usuario, string password, string acceso, string estado, int idempleado)
        {
            CDUsuario objeto = new CDUsuario();
            objeto.Usuario = usuario;
            objeto.Password = password;
            objeto.Acceso = acceso;
            objeto.Estado = estado;
            objeto.Idempleado = idempleado;

            return objeto.Guardar(objeto);
        }

        public static string Editar(int idusuario, string usuario, string password, string acceso, string estado, int idempleado)
        {
            CDUsuario objeto = new CDUsuario();
            objeto.Idusuario = idusuario;
            objeto.Usuario = usuario;
            objeto.Password = password;
            objeto.Acceso = acceso;
            objeto.Estado = estado;
            objeto.Idempleado = idempleado;
            return objeto.Editar(objeto);
        }

        public static string Eliminar(int idusuario)
        {
            CDUsuario objeto = new CDUsuario();
            objeto.Idusuario = idusuario;

            return objeto.Eliminar(objeto);
        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            CDUsuario objeto = new CDUsuario();
            objeto.Buscar = textobuscar;

            return objeto.BuscarNombre(objeto);
        }

        public static DataTable BuscarNombreUsuario(string textobuscar)
        {
            CDUsuario objeto = new CDUsuario();
            objeto.Buscar = textobuscar;

            return objeto.BuscarNombreUsuario(objeto);
        }

        public static DataTable Logeo(string usuario, string password)
        {
            CDUsuario objeto = new CDUsuario();
            objeto.Usuario = usuario;
            objeto.Password = password;

            return objeto.Logeo(objeto);
        }
    }
}