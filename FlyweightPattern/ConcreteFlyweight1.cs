using System;

namespace FlyweightPattern
{
	public class ConcreteFlyweight1:Flyweight1
	{
		public override void Operation(int extrinsicstate)
		{
			Console.WriteLine("ConcreteFlyweight: " + extrinsicstate);
		}
	}
}