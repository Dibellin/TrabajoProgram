using System.ComponentModel.DataAnnotations;

namespace Cines.Clases.Ubicacion
{
    internal class Provincias : PaisOrigen
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
        public Provincias(int id, string nom, PaisOrigen pai)
        {
            IdProvincia = id;
            Provincia = nom;
            pais = pai;
        }
    }
}