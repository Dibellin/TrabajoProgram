namespace Cines.Clases
{
    internal class Clasificacion
    {
        private int Id_clasificacion {get; set;}
        private string Descripcion { get; set;}

        public Clasificacion()
        {
            Id_clasificacion = 0;
            Descripcion = string.Empty;
        }
    }
}