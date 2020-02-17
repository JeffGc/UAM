using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ1
{
    class Program 
    {
        static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();

            operaciones.InsertarPersonas(new ClaseDoctor("Pediatra", 123, "Juan", "Perez", 23444));


            operaciones.InsertarPersonas(new ClaseCliente(1111,"@@", 123, "Pedro", "Perez", 23444));


            operaciones.CrearCitas(new Citas(123, "Juan", "Pedro"));

            operaciones.CrearCitas(new Citas(333, "house", "yeah"));

           

            operaciones.EliminarCita(333);

            operaciones.MostrarCitas();




            Console.ReadKey();
        }
    }
}
