namespace Cines.Clases.Ventas
{
    internal class EstadoPago
    {
        private int IdEstadoPago { get; set; }
        private string Estado { get; set; }

        public EstadoPago()
        {
            IdEstadoPago = 0;
            Estado = string.Empty;
        }

        public EstadoPago(int id, string est)
        {
            IdEstadoPago = id;
            Estado = est;
            
        }
    }
}