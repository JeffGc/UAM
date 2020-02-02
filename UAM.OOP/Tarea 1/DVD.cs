using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
	public class DVD : Reproductores

	{
        #region atributosPropios

        // Atributos
        private int _ID;
		private string _Nombre;

        // Propiedades
		public int ID { get => _ID; set => _ID = value; }
		public string Nombre { get => _Nombre; set => _Nombre = value; }
        
        //Constructores
        public DVD()
        {

        }

        public DVD (int ID, string Nombre)
        {
            _ID = ID;
            _Nombre = Nombre;
        }

        #endregion

        #region metodosReproductores
        public override void Play()
		{
			Console.WriteLine("Play DVD");
		}
		public override void Stop()
		{
			Console.WriteLine("Stop DVD");
		}
		public override void Forward()
		{
			Console.WriteLine("Forward DVD");
		}

		public override void Rewind()
		{
			Console.WriteLine("Rewind DVD");
		}
        #endregion

    }
}
