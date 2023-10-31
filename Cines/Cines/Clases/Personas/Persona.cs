namespace Cines.Clases.Personas
{
    internal class Persona
    {
        private string Nombre { get; set; }
        private string Apellido { get; set; }

        public Persona()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
        }
        public Persona(string nom, string ape)
        {
            Nombre = nom;
            Apellido = ape;
        }
    }
}