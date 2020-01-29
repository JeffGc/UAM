using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP.Inteface
{
    interface IMutanteAcciones
    {
        // Firma.. Dice que tiene que implementar la clase que lo hereda dice como lo implementa
        // Solo la interfaz puede tener herencia multiple
        void SuperSalto();   
        void SuperVision();
        void SuperInteligencia();
    }
}
