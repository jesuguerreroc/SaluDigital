using System;
using System.Collections.Generic;
using DAL;
using Entidades;
using ENTITY;

namespace BLL
{
    public class UsuarioBLL
    {
        private UsuarioDAL usuarioDAL = new UsuarioDAL();

        public bool IniciarSesion(string usuario, string contrasena)
        {
      
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                throw new ArgumentException("Por favor, llene todos los campos.");
            }

            var usuarios = usuarioDAL.ObtenerUsuarios();

            foreach (var u in usuarios)
            {
                if (u.NombreUsuario == usuario && u.Contrasena == contrasena)
                {
                    return true; 
                }
            }

            return false; 
        }

        public string RegistrarUsuario(string nombres, string apellidos, string usuario, string contrasena)
        {

            if (string.IsNullOrWhiteSpace(nombres) ||
                string.IsNullOrWhiteSpace(apellidos) ||
                string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(contrasena))
            {
                return "Por favor, complete todos los campos.";
            }

            var usuarios = usuarioDAL.ObtenerUsuarios();
            foreach (var u in usuarios)
            {
                if (u.NombreUsuario.Equals(usuario, StringComparison.OrdinalIgnoreCase))
                {
                    return "El usuario ya existe.";
                }
            }

            var nuevoUsuario = new Usuario(nombres, apellidos, usuario, contrasena);
            usuarioDAL.GuardarUsuario(nuevoUsuario);

            return "Registro exitoso.";
        }
}
}
