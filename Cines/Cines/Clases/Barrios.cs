using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cines.Clases
{
    internal class Barrios:Localidades
    {
        private int id_barrio {get;set;}
        private int nombre_barrio { get;set;}

        public Localidades Localidades { get;set;}

    }
}
