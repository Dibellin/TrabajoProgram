using SistemaCineBack.Acceso_a_Datos.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cines.Acceso_a_Datos.Factory
{
    class Factoria : aFactoria
    {
        public override IDao crearDao()
        {
            return new DaoCine();
        }
    }
}
