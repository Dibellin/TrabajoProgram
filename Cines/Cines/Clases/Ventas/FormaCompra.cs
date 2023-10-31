namespace Cines.Clases.Ventas
{
    internal class FormaCompra
    {
        private int IdFormaCompra { get; set; }
        private string Forma { get; set; }

        public FormaCompra()
        {
            IdFormaCompra = 0;
            Forma = string.Empty;
        }
        public FormaCompra(int id, string form)
        {
            IdFormaCompra = id;
            Forma = form;
            
        }
    }
}