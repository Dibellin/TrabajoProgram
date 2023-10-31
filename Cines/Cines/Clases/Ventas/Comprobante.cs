using Cines.Clases.Cine;
using Cines.Clases.Personas;

namespace Cines.Clases.Ventas
{
    internal class Comprobantes
    {
        private int IdComprobante { get; set; }
        private Clientes cliente { get; set; }
        private Empleados empleado { get; set; }
        private DateTime fecha { get; set; }
        private Cines cine { get; set; }
        private FormaCompra forma { get; set; }

        private EstadoPago estado { get; set; }

        public Comprobantes()
        {
            IdComprobante = 0;
            cliente = new Clientes();
            empleado = new Empleados();
            fecha = DateTime.Now;
            cine = new Cines();
            forma = new FormaCompra();
            estado = new EstadoPago();

        }
        public Comprobantes(int id, Clientes cli, Empleados emp,DateTime fec, Cines cin, FormaCompra form, EstadoPago est)
        {
            IdComprobante = id;
            cliente = cli;
            empleado = emp;
            fecha = fec;
            cine = cin;
            forma = form;
            estado = est;
        }

    }
}