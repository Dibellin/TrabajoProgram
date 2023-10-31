using Cines.Clases.Ubicacion;

namespace Cines.Clases.Personas
{
    internal class Empleados
    {
        private int IdEmpleado { get; set; }
        private Persona persona { get; set; }
        private string Mail { get; set; }
        private Barrios barrio { get; set; }

        private Cargos cargo { get; set; }

        public Empleados()
        {
            IdEmpleado = 0;
            persona = new Persona();
            Mail = string.Empty;
            barrio = new Barrios();
            cargo = new Cargos();
        }
        public Empleados(int id, Persona pers,string mail, Barrios bar, Cargos carg)
        {
            IdEmpleado = id;
            persona = pers;
            Mail = mail;
            barrio = bar;
            cargo = carg;
            
        }
    }
}