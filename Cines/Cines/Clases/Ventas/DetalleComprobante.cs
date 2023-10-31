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
    internal class DetalleComprobante
    {
        private int IdDetalleComprobante { get; set; }
        private Comprobantes comprobante { get; set; }
        private Funciones funcione { get; set; }
        private ButacasFunciones butacaXfuncion { get; set; }

        private FormaPago formaPago { get; set; }
        private double precio { get; set; }

        public DetalleComprobante()
        {
            IdDetalleComprobante = 0;
            comprobante = new Comprobantes();
            funcione = new Funciones();
            butacaXfuncion = new ButacasFunciones();
            formaPago = new FormaPago();
            precio = 0;
        }
        public DetalleComprobante(int id, Comprobantes comp, Funciones fun, ButacasFunciones bxf, FormaPago forma, double pre)
        {
            IdDetalleComprobante = id;
            comprobante = comp;
            funcione = fun;
            butacaXfuncion = bxf;
            formaPago = forma; 
            precio = pre;
        }
    }
}
