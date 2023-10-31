using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cines.Clases.Cines.Cine
{
    internal class Butacas
    {
        private int IdButaca { get; set; }
        private int NroButaca { get; set; }
        private int Fila { get; set; }

        private Salas sala { get; set; }


        public Butacas()
        {
            IdButaca = 0;
            NroButaca = 0;
            Fila = 0;
            sala = new Salas();

        }
        public Butacas(int Id, int Nro,int fila)
        {
            IdButaca = Id;
            NroButaca = Nro;
            Fila = fila;
             
        }
    }
}
