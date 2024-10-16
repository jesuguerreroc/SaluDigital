using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Cita
    {
    
            private int _IdMedico;
            private string _DniMedico;
            private int _IdCita;
            private string _DniPaciente;
            private int _IdPaciente;
            private DateTime _FechaCita;
            private TimeSpan _HoraCita;

            public int IdMedico { get => _IdMedico; set => _IdMedico = value; }
            public string DniMedico { get => _DniMedico; set => _DniMedico = value; }
            public int IdTurno { get => _IdCita; set => _IdCita = value; }
            public string DniPaciente { get => _DniPaciente; set => _DniPaciente = value; }
            public DateTime FechaTurno { get => _FechaCita; set => _FechaCita = value; }
            public TimeSpan HoraTurno { get => _HoraCita; set => _HoraCita = value; }
            public int IdPaciente { get => _IdPaciente; set => _IdPaciente = value; }
        }
    }


