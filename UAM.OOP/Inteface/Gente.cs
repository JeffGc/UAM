using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP.Inteface
{
     // "Herencia multiple" en este caso es como que tengo que hacer
    public class Gente : IAccionesPersona, IMutanteAcciones
    {
        public void Caminar()
        {
            throw new NotImplementedException();  // Es como el try & catch de java
        }

        public void Comer()
        {
            throw new NotImplementedException();
        }

        public void Correr()
        {
            throw new NotImplementedException();
        }

        public void SuperInteligencia()
        {
            throw new NotImplementedException();
        }

        public void SuperSalto()
        {
            throw new NotImplementedException();
        }

        public void SuperVision()
        {
            throw new NotImplementedException();
        }
    }
}
