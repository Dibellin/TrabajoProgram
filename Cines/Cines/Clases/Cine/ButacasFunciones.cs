using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cines.Clases.Cines.Cine
{
    internal class ButacasFunciones
    {
        private int IdButacasFuncion { get; set; }
        private Butacas butaca { get; set; }
        private Funciones funcion { get; set; }

        private Reservas reserva { get; set; }

        public ButacasFunciones()
        {
            IdButacasFuncion = 0;
            butaca = new Butacas();
            funcion = new Funciones();
            reserva = new Reservas();
        }

        public ButacasFunciones(int id, Butacas but, Funciones fun, Reservas res)
        {
            IdButacasFuncion = id;
            butaca = but;
            funcion = fun;
            reserva = res;
             
        }
    }
}
