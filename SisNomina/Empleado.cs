using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisNomina
{
   abstract public class Empleado : Persona
    {
        public int IdEmpleado { get; set; }
        public string Puesto { get; set; }
        public string Departamento { get; set; }
        public float SueldoPorHora { get; set; }
        public bool Activo { get; set; }
    }
}
