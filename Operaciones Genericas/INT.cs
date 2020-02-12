using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_Genericas
{
    class INT : IOperaciones<int>
    {
        #region INT
        //Atributos
        private int _a, _b;


        //Get y set

        public int A { get => _a; set => _a = value; }
        public int B { get => _b; set => _b = value; }

        //Constructores

        public INT()
        {           
        }

        public INT(int a, int b)
        {
            A = a;
            B = b;
        }
        #endregion

        public int Suma(int a, int b)
        {
            
            return(a+b);
        }

        public int Resta(int a, int b)
        {
           
            return (a - b);
        }

        public int Division(int a, int b)
        {

            return b>0?(a / b):0;
        }

        public int Multiplicaion(int a, int b)
        {
            return (a * b);
        }

    }
}
