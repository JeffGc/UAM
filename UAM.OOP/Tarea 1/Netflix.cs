using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{

	public class Netflix : Reproductores

	{
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



	}
}
