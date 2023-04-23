using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLinq
{
    [DebuggerDisplay("{nombre}")]
    internal class Persona
    {
        public Persona() { }

        public Persona(int id) { }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; } = 0;
        public bool Soltero { get; set; }
        public DateTime FechaIngresoALaEmpresa { get; set; }
        public List<string> Telefono = new List<string>();
        public int EmpresaId { get; set; }
        public int City { get; set; }
        public int Country { get; set; }
        public int Fax { get; set; }
        public int Gender { get; set; }   
    }
}
