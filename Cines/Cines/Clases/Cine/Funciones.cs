using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cines.Clases.Cine
{
    internal class Funciones
    {
        private int IdFuncion { get; set; }
        private DateTime Hora { get; set; }
        private DateTime Fecha { get; set; }
        private Salas sala { get; set; }
        private Peliculas pelicula { get; set; }
        private double Precio { get; set; }

        private TipoFormato formato { get; set; }

        public Funciones()
        {
            IdFuncion = 0;
            Hora = DateTime.Now;
            Fecha = DateTime.Now;
            sala = new Salas();
            pelicula = new Peliculas();
            Precio = 0;
            formato = new TipoFormato();
        }
        public Funciones(int id, DateTime hor,DateTime fec, Salas sal, Peliculas pel, double pre, TipoFormato tip)
        {
            IdFuncion = id;
            Hora = hor;
            Fecha = fec;
            sala = sal;
            pelicula = pel;
            formato = tip;
            Precio = pre;
            
        }


    }
}
