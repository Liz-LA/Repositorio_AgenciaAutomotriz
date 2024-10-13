using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioPantalla
    {

        public class Usuario
        {
            public string Nombre { get; set; }
            public string Rol { get; set; }

            public Usuario(string nombre, string rol)
            {
                Nombre = nombre;
                Rol = rol;
            }
        }

    }
}
