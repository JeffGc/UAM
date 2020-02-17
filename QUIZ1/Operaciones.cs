using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ1
{
    class Operaciones : ICRUD<ClasePersona>
    {
        List<ClasePersona> Lista = new List<ClasePersona>();

        List<Citas> ListaCitas = new List<Citas>();

        public ClasePersona Buscar(int indice)
        {
            throw new NotImplementedException();
        }
     
        // Crear citas
        public void CrearCitas(Citas item)
        {
            ListaCitas.Add(item);     
        }
        //MostarTabla Citas
        public void MostrarCitas()
        {
            Console.WriteLine();
            foreach (Citas citas in ListaCitas)
            {
                Console.WriteLine(citas);
            }
        }
        //Eliminar Citas
        public void EliminarCita(int IdCita)
        {
             ListaCitas.IndexOf(IdCita);
        }

        //Inserta en lista
        public void InsertarPersonas(ClasePersona item)
        {
            Lista.Add(item);

        }

       
       



        // Agregar a lista
        //IList.Add(new ClaseCliente(1234, "DVD", 111, "Jeff", "GC", 123));

        //Lista.Add(new ClaseDoctor("Pediatra", 111, "Jeff", "GC", 123));



    }
}
