using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
	public abstract class Carnivore
	{
		public abstract void Eat(Herbivore h);
	}
}
