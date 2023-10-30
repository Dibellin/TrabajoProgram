using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cines.Clases
{
    internal class Genero
    {
        private int id_genero {get;set;}
        private string name_genero { get;set;}

        public Genero()
        {
            id_genero = 0;
            name_genero = string.Empty;
        }
    }
}
