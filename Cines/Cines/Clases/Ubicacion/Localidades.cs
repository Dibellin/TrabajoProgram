namespace Cines.Clases.Ubicacion
{
    internal class Localidades : Provincias
    {
        private int id_localidad { get; set; }
        private string nom_localidad { get; set; }

        public Provincias Provincias { get; set; }

        public Localidades()
        {
            id_localidad = 0;
            nom_localidad = string.Empty;
            Provincias = new Provincias();
        }
        public Localidades(int id, string nombre, Provincias prov)
        {
            id_localidad = id;
            nom_localidad = nombre;
            Provincias = prov;
        }
    }
}