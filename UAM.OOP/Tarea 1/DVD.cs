using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
	public class DVD : Reproductores

	{
		private int _ID;
		private string _Nombre;

		public int ID { get => _ID; set => _ID = value; }
		public string Nombre { get => _Nombre; set => _Nombre = value; }

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
