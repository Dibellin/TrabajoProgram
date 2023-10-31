namespace Cines.Clases.Ubicacion
{
    internal class PaisOrigen
    {
        private int IdPais { get; set; }
        private string Pais { get; set; }

        public PaisOrigen()
        {
            IdPais = 0;
            Pais = string.Empty;
        }
        public PaisOrigen(int id, string nom)
        {
            IdPais = id;
            Pais = nom;
        }
    }
}