using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
	public class EventLog:Log
	{
		public override void Write()
		{
			Console.WriteLine("EventLog Write Success!");
		}
	}
}
