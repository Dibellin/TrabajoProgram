namespace Cines.Clases.Ventas
{
    internal class FormaPago
    {
        private int IdFormaPago { get; set; }
        private string Forma { get; set; }

        public FormaPago()
        {
            IdFormaPago = 0;
            Forma = string.Empty;
        }
        public FormaPago(int id, string form)
        {
            IdFormaPago = id;
            Forma = form;
        }
    }
}