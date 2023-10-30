using Cines.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCineBack.Acceso_a_Datos.Dao
{
    interface IDao
    {
        bool crear(Funciones funcion);
        bool borrar(Funciones funcion);
        int proximoID();
        List<Asientos> consultar();
    }
}
