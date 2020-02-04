using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
    public class ImplementarInterface<T> : CRUD
    {
        List<T> listaT = new List<T>();
        public void Buscar<T>()
        {
            throw new NotImplementedException();
        }

        public void Eliminar<T>()
        {
            throw new NotImplementedException();
        }

        public void Insertar<T>()
        {
            throw new NotImplementedException();
        }
    }
}
