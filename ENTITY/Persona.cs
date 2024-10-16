using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string _dni;
        private string _IdSexo;
        private string _nombre;
        private string _apellido;
        private DateTime _FechaNacimiento;
        private string _email;
        private string _telefono;

        public string Dni { get => _dni; set => _dni = value; }
        public string IdSexo { get => _IdSexo; set => _IdSexo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public DateTime FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public string Email { get => _email; set => _email = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
    }
}