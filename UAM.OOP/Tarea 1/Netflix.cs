using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{

	public class Netflix : Reproductores

	{
        #region atributosPropios

        // Atributos
        private int _ID;
        private string _Nombre;

        // Propiedades
        public int ID { get => _ID; set => _ID = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }

        //Constructores
        public Netflix()
        {

        }

        public Netflix(int ID, string Nombre)
        {
            _ID = ID;
            _Nombre = Nombre;
        }

        #endregion

        #region metodosReproductores
        public override void Play()
		{
			Console.WriteLine("Play Netflix");
		}
		public override void Stop()
		{
			Console.WriteLine("Stop Netflix");
		}
		public override void Forward()
		{
			Console.WriteLine("Forward Netflix");
		}

		public override void Rewind()
		{
			Console.WriteLine("Rewind Netflix");
		}
        #endregion


    }
}
