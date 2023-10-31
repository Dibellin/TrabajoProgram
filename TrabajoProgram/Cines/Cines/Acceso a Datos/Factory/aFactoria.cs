using SistemaCineBack.Acceso_a_Datos.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cines.Acceso_a_Datos.Factory
{
    abstract class aFactoria
    {
        public abstract IDao crearDao();
    }
}
