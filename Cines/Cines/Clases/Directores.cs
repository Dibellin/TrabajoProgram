using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cines.Clases
{
    internal class Directores:Persona
    {
        private int id_Director {get;set;}
        private DateTime Fec_comienzo { get;set;}

        private Persona Persona { get;set;}
        public Directores()
        {
                id_Director = 0;
            Fec_comienzo = DateTime.Now;
            Persona = new Persona();
        }
    }
}
