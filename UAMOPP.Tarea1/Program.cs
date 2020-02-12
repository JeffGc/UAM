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

            //ICRUD<IReproductores> lista = new Listas();

            Listas ejemplo = new Listas();

            // Formas de Instanciar el objeto

            //1
            IReproductores VHS = new VHS(0, "VHS");
            ejemplo.Insertar(VHS);


            //2
            ejemplo.Insertar(new DVD(1, "DVD"));

            //3
            ejemplo.Insertar(new Netflix() { ID = 1, Nombre = "Netflix" }); 

            ejemplo.Eliminar(0);

            ejemplo.Buscar(0);

            Console.ReadKey();

        }
    }
}
