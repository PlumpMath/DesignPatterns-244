using System;

namespace DecoratorPatter
{
	public class DatabaseLog:Log
	{
		public override void Write(string log)
		{
			Console.WriteLine("Databa Log");
		}
	}
}