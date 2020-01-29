using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
	public abstract class PersonaDeportesCAbst
	{

        // Se le dice que tiene que implementar pero no como
		public abstract void Futbol();

		public abstract void Basket();


        // Se dice que hereda y le da la opcion de usar la implentacion de la base o da chance de hacer otra *override  en lugar de virtual en la clase hija
		public virtual void Tennis() {
			Console.WriteLine("AbstClass->Jugando Tennis");
		}

        // Le dice que hereda y como, no hay mas opcion
		public void BaseBall() {
			Console.WriteLine("AbstClass->Jugando BaseBall");
		}

	}
}
