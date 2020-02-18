using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ1
{
    class Operaciones
    {
        List<ClasePersona> Lista = new List<ClasePersona>();

        List<Citas> ListaCitas = new List<Citas>();


        //Inserta en lista
        public void InsertarPersonas(ClasePersona item)
        {
            Lista.Add(item);
        }


        public void ImrimirPersonas()
        {

            Console.WriteLine();
            foreach (ClasePersona persona in Lista)
            {
                Console.WriteLine("\n " + persona.NombreCompleto());
            }
        }


        // Crear citas
        public void CrearCitas(Citas item)
        {
            ListaCitas.Add(item);
        }

        //MostarTabla Citas
        public void MostrarCitas()
        {
            Console.WriteLine(" \nCitas programadas: ");
            foreach (Citas citas in ListaCitas)
            {
                Console.WriteLine(citas);
            }
        }

        //Eliminar Citas
        public void EliminarCita(int IdCita)
        {
            ListaCitas.RemoveAt(IdCita);
        }

    }
}
