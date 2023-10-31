using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cines.Clases.Ubicacion;

namespace Cines.Clases.Cine
{
    internal class Cines
    {
        private int IdCines { get; set; }
        private Barrios Barrios { get; set; }

        private string Cine { get; set; }

        public Cines()
        {
            IdCines = 0;
            Barrios = new Barrios();
            Cine = string.Empty;
        }
        public Cines(int id, Barrios bar, string nombre)
        {
            IdCines = id;
            Barrios = bar;
            Cine = nombre;
            
        }
    }
}
