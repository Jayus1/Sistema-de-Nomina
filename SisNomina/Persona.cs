using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisNomina
{
    abstract public class Persona: BD
    {
        public int IdPersona { get; set; }
        public string Name { get; set; }
        public string Apellido { get; set; }
        public int Cedula { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string Direccion { get; set; }
        public long Telefono { get; set; }
        public string Correo { get; set; }

    }
}
