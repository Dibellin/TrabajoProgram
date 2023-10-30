using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cines.Clases
{
    internal class Idioma
    {
        private int Id_Idioma { get; set; }
        private string Lenguaje { get; set; }

        public Idioma()
        {
            Id_Idioma = 0;
            Lenguaje = string.Empty;
        }
    }
}
