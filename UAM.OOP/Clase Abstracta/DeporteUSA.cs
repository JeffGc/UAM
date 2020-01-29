using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
    public class DeporteUSA : PersonaDeportesCAbst
    {
        public override void Basket()
        {
            Console.WriteLine("AbstClass-> NBA");
        }

        public override void Futbol()
        {
            Console.WriteLine("AbstClass-> NFL");
        }


        public override void Tennis()
        {
            Console.WriteLine("DeporteUSA ->Jugando Tennis Sintetico");
        }

        // Ejemplo de como se necita virtual en el metodo
        //public override void BaseBall()
        //{
        //    Console.WriteLine("DeporteUSA ->Jugando Tennis Sintetico");
        //}
    }
}
