using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_Genericas
{
    class Program
    {
        static void Main(string[] args)
        {

            IOperaciones<string> Operaciones = new String();

          // Console.WriteLine(Operaciones.Suma(1,2));

            Console.WriteLine(Operaciones.Multiplicaion("Casa", "lol"));

            Console.ReadKey();
        }
    }
}
