using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cines.Clases.Cine
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
        public Idioma(int id , string len)
        {
            Id_Idioma = id;
            Lenguaje = len;
            
        }
    }
}
