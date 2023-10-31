namespace Cines.Clases.Cine
{
    internal class TipoSala
    {
        private int IdTipoSala { get; set; }
        private string tipo { get; set; }

        public TipoSala()
        {
            IdTipoSala = 0;
            tipo = string.Empty;
        }
        public TipoSala(int id, string tip)
        {
            IdTipoSala = id;
            tipo = tip;
             
        }
    }
}