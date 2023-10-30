using System.ComponentModel.DataAnnotations;

namespace Cines.Clases
{
    internal class Provincias:PaisOrigen
    {
        public int IdProvincia { get; set; }

        public string Provincia { get; set; }

        public PaisOrigen pais { get; set; }

        public Provincias()
        {
            IdProvincia = 0;
            Provincia = string.Empty;
            pais = new PaisOrigen();
        }
    }
}