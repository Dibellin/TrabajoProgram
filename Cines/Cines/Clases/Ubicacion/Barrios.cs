using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cines.Clases.Ubicacion
{
    internal class Barrios : Localidades
    {
        private int idBarrio { get; set; }
        private string barrio { get; set; }

        public Localidades Localidad { get; set; }

        public Barrios()
        {
            idBarrio = 0;
            barrio = string.Empty;
            Localidad = new Localidades();
        }
        public Barrios(int id,string bar, Localidades loc )
        {
             idBarrio = id;
            barrio = bar;
            Localidad = loc;
        }

    }
}
