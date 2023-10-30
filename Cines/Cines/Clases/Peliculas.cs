using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cines.Clases
{
    internal class Peliculas
    {
        private int IdPelicula {get; set;}
        private string Titulo { get; set;}
        private double Duracion { get; set;}
        private Genero Genero { get; set;}
        private Clasificacion clasificacion { get; set;}

        private Idioma Idioma { get; set;}
        private DateTime Fec_Estreno { get; set;}
        private PaisOrigen Pais { get; set;}

        public Peliculas()
        {
            IdPelicula = 0;
            Titulo = string.Empty;
            Duracion = 0;
            Genero = new Genero();
            clasificacion = new Clasificacion();
            Idioma = new Idioma();
            Fec_Estreno = DateTime.Now;
            Pais = new PaisOrigen();
        }
    }
}
