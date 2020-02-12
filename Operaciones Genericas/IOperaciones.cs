using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_Genericas
{
    interface IOperaciones <T>
    {
        T Suma(T a, T b);
        T Resta(T a, T b);
        T Division(T a, T b);
        T Multiplicaion(T a, T b);
    }
}
