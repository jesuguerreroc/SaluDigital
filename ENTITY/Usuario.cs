using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }

        public Usuario(string nombres, string apellidos, string usuario, string contrasena)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            NombreUsuario = usuario;
            Contrasena = contrasena;
        }
    }
}
