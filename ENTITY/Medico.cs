using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico
    {
        private int _IdMedico;
        private string _DniMedico;
        private string _IdRol;
        private int _IdUsuario;

        public int IdMedico { get => _IdMedico; set => _IdMedico = value; }
        public string DniMedico { get => _DniMedico; set => _DniMedico = value; }
        public string IdRol { get => _IdRol; set => _IdRol = value; }
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }

    }
}