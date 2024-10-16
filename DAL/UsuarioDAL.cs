using System;
using System.Collections.Generic;
using System.IO;
using Entidades;
using ENTITY;

namespace DAL
{
    public class UsuarioDAL
    {
        private readonly string rutaArchivo = @"C:\Users\jesug\source\repos\SaluDigital\DAL\usuarios.txt";
        public List<Usuario> ObtenerUsuarios()
        {
            var usuarios = new List<Usuario>();

            if (!File.Exists(rutaArchivo))
            {
                throw new FileNotFoundException("No se encontró el archivo de usuarios.");
            }

            var lineas = File.ReadAllLines(rutaArchivo);

            foreach (var linea in lineas)
            {
                var datos = linea.Split(';');
                if (datos.Length >= 4)
                {
                    var usuario = new Usuario(datos[0], datos[1], datos[2], datos[3]);
                    usuarios.Add(usuario);
                }
            }

            return usuarios;
        }

        public void GuardarUsuario(Usuario usuario)
        {
            string datosUsuario = $"{usuario.Nombres};{usuario.Apellidos};{usuario.NombreUsuario};{usuario.Contrasena}";
            try
            {
                File.AppendAllText(rutaArchivo, datosUsuario + Environment.NewLine);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar los datos: {ex.Message}");
            }
        }
    }
}