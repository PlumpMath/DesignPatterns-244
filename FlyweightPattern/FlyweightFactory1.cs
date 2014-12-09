using System.Collections;

namespace FlyweightPattern
{
	public class FlyweightFactory1
	{
		private Hashtable flyweights = new Hashtable();

		// Constructor
		public FlyweightFactory1()
		{
			flyweights.Add("X", new ConcreteFlyweight1());
			flyweights.Add("Y", new ConcreteFlyweight1());
			flyweights.Add("Z", new ConcreteFlyweight1());
		}

		public Flyweight1 GetFlyweight(string key)
		{
			return ((Flyweight1)flyweights[key]);
		} 
	}
}