using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
	public class VHS : Reproductores

	{
        #region atributosPropios

        // Atributos
        private int _ID;
        private string _Nombre;

        // Propiedades
        public int ID { get => _ID; set => _ID = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }

        //Constructores
        public VHS()
        {

        }

        public VHS(int ID, string Nombre)
        {
            _ID = ID;
            _Nombre = Nombre;
        }

        #endregion

        #region metodosReproductores
        public override void Play()
		{
			Console.WriteLine("Play VHS");
		}
		public override void Stop()
		{
			Console.WriteLine("Stop VHS");
		}
		public override void Forward()
		{
			Console.WriteLine("Forward VHS");
		}

		public override void Rewind()
		{
			Console.WriteLine("Rewind VHS");
		}

        #endregion

    }
}
