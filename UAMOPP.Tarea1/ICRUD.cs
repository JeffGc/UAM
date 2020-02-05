using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMOPP.Tarea1
{
    interface ICRUD<T>
    {
        void Insertar(T item);
        void Eliminar(int indice);
        T Buscar(int indice);

        void Imprimir();

    }
}
