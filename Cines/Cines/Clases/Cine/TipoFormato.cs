namespace Cines.Clases.Cine
{
    internal class TipoFormato
    {
        private int IdTipoFormato { get; set; }
        private string Tipo { get; set; }
        public TipoFormato()
        {
            IdTipoFormato = 0;
            Tipo = string.Empty;
        }
        public TipoFormato(int id, string tip)
        {
            IdTipoFormato = id;
            Tipo = tip;
            
        }
    }
}