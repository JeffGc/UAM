using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_Genericas
{
    class String : IOperaciones<string>
    {
        public string Division(string a, string b)
        {
            throw new NotImplementedException();
        }

        public string Multiplicaion(string a, string b)
        {

            int max =  a.Length > b.Length ? ( max = b.Length): max = a.Length ;

            string newString ="";

            for (int i = 0; i < max; i++) {
                newString = newString + a[i] + b[i];
            }

            return newString;                  
        }

        public string Resta(string a, string b)
        {
            return a.Length > b.Length ? (b) : a;
        }

        public string Suma(string a, string b)
        {
            return a + b;
         
        }
    }
}
