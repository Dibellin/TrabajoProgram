using Cines.Clases.Cines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCineBack.Acceso_a_Datos.Dao
{
    class DaoCine : IDao
    {
        public bool borrar(Funciones funcion)
        {
            throw new NotImplementedException();
        }

        public List<Asientos> consultar()
        {
            throw new NotImplementedException();
        }

        public bool crear(Funciones funcion)
        {
            return HelperDB.obtenerInstancia().ejecutarSql("", "", );
        }

        public int proximoID()
        {
            return HelperDB.obtenerInstancia().obtenerProximoId();
        }
    }
}
