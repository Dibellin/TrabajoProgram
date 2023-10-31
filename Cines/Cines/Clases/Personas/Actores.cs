using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cines.Clases.Personas
{
    internal class Actores : Persona
    {
        private int id_actor { get; set; }

        private DateTime Fec_Comienzo { get; set; }
        private DateTime Fec_Nacimiento { get; set; }

        private Persona Persona { get; set; }

        public Actores()
        {
            id_actor = 0;
            Fec_Comienzo = DateTime.MinValue;
            Fec_Nacimiento = DateTime.MinValue;
            Persona = new Persona();
        }
        public Actores(int id, DateTime comienzo, DateTime nac, Persona pers)
        {
            id_actor = id;
            Fec_Comienzo = comienzo;
            Fec_Nacimiento= nac;
            Persona = pers;
        }
    }
}
