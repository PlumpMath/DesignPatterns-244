using System;

namespace FlyweightPattern
{
	public class UnsharedConcreteFlyweight1 : Flyweight1
	{
		public override void Operation(int extrinsicstate)
		{
			Console.WriteLine("UnsharedConcreteFlyweight: " + extrinsicstate);
		}
	}
}