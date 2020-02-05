using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMOPP.Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            IReproductores reproductores = new VHS();

            ICRUD<IReproductores> lista = new Listas();

            Listas ejemple = new Listas();



            IReproductores VHS = new VHS(0,"VHS");

            lista.Insertar(VHS);

            Console.ReadKey();

           

            }
    }
}
