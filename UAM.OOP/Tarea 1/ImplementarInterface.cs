using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
    public class ImplementarInterface<T> : ICRUD<T>
    {
        List<T> lista = new List<T>();

        public T Buscar(int posicion)
        {

            Console.WriteLine("Buscando elemento en posicion: " + posicion + "\n");
            return lista.ElementAt(posicion);
        }

        public void Eliminar(int indice)
        {
            lista.RemoveAt(indice);
            Console.WriteLine("Eliminando: " + indice + "\n");
        }

        public void Insertar(T item)
        {
            lista.Add(item);
            Console.WriteLine("Insertando: " + item + "\n");
        }
    }
}
