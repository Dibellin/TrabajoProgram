using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cines.Clases.Cine;
using Cines.Clases.Cines;
using Cines.Clases.Cines.Cine;

namespace Cines.Clases.Ventas
{
    internal class Ticket
    {
        private int IdTicket { get; set; }
        private Comprobantes comprobante { get; set; }
        private Butacas butaca { get; set; }
        private Funciones funcion { get; set; }
        private double Precio { get; set; }

        public Ticket()
        {
            IdTicket = 0;
            comprobante = new Comprobantes();
            funcion = new Funciones();
            butaca = new Butacas();
            Precio = 0;
        }

        public Ticket(int id, Comprobantes comp, Butacas but, Funciones func, double pre)
        {
            IdTicket = id;
            comprobante = comp;
            funcion = func;
            butaca = but;
            Precio = pre;
            
        }
    }
}
