using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMOPP.Tarea1
{
    class Listas : ICRUD<IReproductores>
    {
        List<IReproductores> lista = new List<IReproductores>();

        public IReproductores Buscar(int indice)
        {

            return lista.ElementAt(indice);
        }

        public void Eliminar(int indice)
        {
            lista.RemoveAt(indice);
        }

      

        public void Insertar(IReproductores item)
        {
            lista.Add(item);
        }

        
    }
}
