namespace Cines.Clases
{
    internal class Salas
    {
        private int IdSala {get;set;}
        private int Numero { get;set;}

        private TipoSala tipo {get;set;}

        private int Asientos { get;set;}

        private Cines cine {get;set;}

        public Salas()
        {
            IdSala = 0;
            Numero = 0;
            tipo = new TipoSala();
            Asientos = 0;
            cine = new Cines();
        }

    }
}