using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
	public class VHS : Reproductores

	{
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



	}
}
