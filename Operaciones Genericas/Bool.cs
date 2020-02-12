using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_Genericas
{
    class Bool : IOperaciones<bool>
    {
        public bool Division(bool a, bool b)
        {
            return!(a && b);
        }

        public bool Multiplicaion(bool a, bool b)
        {
            return !(a || b);
        }

        public bool Resta(bool a, bool b)
        {
            return (a && b);
        }

        public bool Suma(bool a, bool b)
        {
            return (a || b);
        }
    }
}
