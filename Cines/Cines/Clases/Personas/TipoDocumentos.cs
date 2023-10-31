namespace Cines.Clases.Personas
{
    internal class TipoDocumentos
    {
        private int IdTipoDocumento { get; set; }
        private string Tipo { get; set; }

        public TipoDocumentos()
        {
            IdTipoDocumento = 0;
            Tipo = string.Empty;
        }
        public TipoDocumentos(int id, string tipo)
        {
            IdTipoDocumento = id;
            Tipo = tipo;
            
        }
    }
}