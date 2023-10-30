using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cines.Clases
{
    internal class Funciones
    {
        private int IdFuncion { get; set; }
        private DateTime Hora { get; set; }
        private DateTime Fecha { get; set; }
        private Salas sala { get; set; }
        private Peliculas pelicula { get; set; }
        private double Precio { get; set; }

        private Tipo_Formato formato { get; set; }

        public Funciones()
        {
            IdFuncion = 0;
            Hora = DateTime.Now;
            Fecha = DateTime.Now;
            sala = new Salas();
            pelicula = new Peliculas();
            Precio = 0;
            formato = new Tipo_Formato();
        }


    }
}
