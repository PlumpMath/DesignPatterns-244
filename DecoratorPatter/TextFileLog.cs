using System;

namespace DecoratorPatter
{
	public class TextFileLog:Log
	{
		public override void Write(string log)
		{
			Console.WriteLine("Textfile log");
		}
	}
}