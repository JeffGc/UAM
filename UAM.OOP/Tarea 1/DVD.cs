using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
	public class DVD : Reproductores

	{
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



	}
}
