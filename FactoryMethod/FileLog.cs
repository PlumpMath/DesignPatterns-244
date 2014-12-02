using System;

namespace FactoryMethod
{
	public class FileLog:Log
	{
		public override void Write()
		{
			Console.WriteLine("FileLog Write Success!");
		}
	}
}