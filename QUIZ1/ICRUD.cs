using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ1
{
    interface ICRUD<T>
    {
        void InsertarPersonas(T item);
       
        T Buscar(int indice);
    }
}
