using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicios_LINQ_Parte_2
{
     [DebuggerDisplay("{Nombre}")]
        public class Carro
    {
         public string Nombre { get; set; }
        public int Año { get; set; }
        public bool Viejo { get; set; }
        public DateTime FechaFabricacion { get; set; }

        public bool Fallas {get; set;}
        public int AgenciaId { get; set; }

         public List<string> Placas = new List<string>();


    }
}