using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
    interface ICRUD<T>
    {
        void Insertar(T item);
        void Eliminar(int indice);
        T Buscar(int posicion);
    }
}
