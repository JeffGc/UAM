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

            // Insertar Doctores
            operaciones.InsertarPersonas(new ClaseDoctor("Pediatra", 1, "Juan", "Perez", 107760365));
            operaciones.InsertarPersonas(new ClaseDoctor("Gediatra", 2, "James", "Sully", 402250186));
            operaciones.InsertarPersonas(new ClaseDoctor("General", 3, "Greg", "House", 605580693));


            // Insertar pacientes
            operaciones.InsertarPersonas(new ClaseCliente(22696269, "primero@quiz.com", 101, "Pedro", "Perez", 116620223));
            operaciones.InsertarPersonas(new ClaseCliente(23606270, "segundo@quiz.com", 102, "Juan", "Arguedas", 503360489));
            operaciones.InsertarPersonas(new ClaseCliente(24616271, "tercero@quiz.com", 103, "Oscar", "Lopez", 255580336));
            operaciones.InsertarPersonas(new ClaseCliente(25626272, "cuarto@quiz.com", 104, "Esteban", "Barboza", 103360225));
            operaciones.InsertarPersonas(new ClaseCliente(26636273, "quinto@quiz.com", 105, "Max", "Cortes", 200440580));
            operaciones.InsertarPersonas(new ClaseCliente(27646274, "sexto@quiz.com", 106, "Julie", "Ferrer", 306690587));
            operaciones.InsertarPersonas(new ClaseCliente(28656275, "setimo@quiz.com", 107, "Ari", "Gomez", 70883001));
            operaciones.InsertarPersonas(new ClaseCliente(29666276, "octavo@quiz.com", 109, "Nataly", "Hidalgo", 101110321));
            operaciones.InsertarPersonas(new ClaseCliente(20676277, "noveno@quiz.com", 110, "Katty", "Marin", 109990874));
            operaciones.InsertarPersonas(new ClaseCliente(21686278, "decimo@quiz.com", 111, "Mario", "Nieto", 402250875));
           
            operaciones.ImrimirPersonas();

            // Crear Citas

            
            operaciones.CrearCitas(new Citas(123, "James", "Pedro"));

            operaciones.CrearCitas(new Citas(333, "Greg", "Mario"));

            
            operaciones.MostrarCitas();


            operaciones.EliminarCita(0);

            operaciones.MostrarCitas();

            Console.ReadKey();
        }
    }
}
