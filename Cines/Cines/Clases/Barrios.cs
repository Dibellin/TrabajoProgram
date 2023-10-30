using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cines.Clases
{
    internal class Barrios:Localidades
    {
        private int idBarrio {get;set;}
        private int barrio { get;set;}

        public Localidades Localidades { get;set;}

        public Barrios()
        {
                idBarrio = 0;
            barrio = 0;
            Localidades = new Localidades();
        }

    }
}
