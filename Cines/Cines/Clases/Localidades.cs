namespace Cines.Clases
{
    internal class Localidades:Provincias
    {
        private int id_localidad {  get; set; }
        private string nom_localidad { get; set;}

        public Provincias Provincias { get; set; }

        public Localidades()
        {
                id_localidad = 0;
            nom_localidad = string.Empty;
            Provincias = new Provincias();
        }
    }
}