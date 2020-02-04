using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
    interface CRUD
    {
        void Insertar<T>();
        void Eliminar<T>();
        void Buscar<T>();
    }
}
