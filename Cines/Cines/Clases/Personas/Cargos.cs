using System.CodeDom;

namespace Cines.Clases.Personas
{
    internal class Cargos
    {
        private int IdCargos { get; set; }
        private string Cargo { get; set; }

        public Cargos()
        {
            IdCargos = 0;
            Cargo = string.Empty;
        }
        public Cargos(int id, string carg)
        {
            IdCargos = id;
            Cargo = carg;
            
        }
    }
}