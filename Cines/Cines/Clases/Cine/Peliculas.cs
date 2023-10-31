using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cines.Clases.Ubicacion;

namespace Cines.Clases.Cine
{
    internal class Peliculas
    {
        private int IdPelicula { get; set; }
        private string Titulo { get; set; }
        private double Duracion { get; set; }
        private Genero Genero { get; set; }
        private Clasificacion clasificacion { get; set; }

        private Idioma Idioma { get; set; }
        private DateTime Fec_Estreno { get; set; }
        private PaisOrigen Pais { get; set; }

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
        public Peliculas(int id, string title, double dur, Genero gen, Clasificacion clasf, Idioma idiom, DateTime estreno, PaisOrigen pais)
        {
            IdPelicula = id;
            Titulo = title;
            Duracion = dur;
            Genero = gen;
            clasificacion = clasf;
            Idioma = idiom;
            Fec_Estreno = estreno;
            Pais = pais;
        }
    }
}
