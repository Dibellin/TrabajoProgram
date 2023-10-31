namespace Cines.Clases.Cine
{
    internal class Salas
    {
        private int IdSala { get; set; }
        private int Numero { get; set; }

        private TipoSala tipo { get; set; }

        private int Asientos { get; set; }

        private Cines cine { get; set; }

        public Salas()
        {
            IdSala = 0;
            Numero = 0;
            tipo = new TipoSala();
            Asientos = 0;
            cine = new Cines();
        }
        public Salas(int id, int nro, TipoSala tip, int asient, Cines cin)
        {
            IdSala = id;
            Numero = nro;
            tipo = tip;
            Asientos = asient;
            cine = cin;
             
        }
    }
}