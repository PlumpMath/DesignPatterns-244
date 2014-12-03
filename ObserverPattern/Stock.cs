using System;
using System.Collections.Generic;

namespace ObserverPattern
{
	public abstract class Stock
	{
		private List<IObserver> observers = new List<IObserver>();

		private String _symbol;

		private double _price;

		public Stock(String symbol, double price)
		{
			this._symbol = symbol;

			this._price = price;
		}

		public void Update()
		{
			foreach (IObserver ob in observers)
			{
				ob.SendData(this);
			}

		}

		public void AddObserver(IObserver observer)
		{
			observers.Add(observer);
		}

		public void RemoveObserver(IObserver observer)
		{
			observers.Remove(observer);
		}

		public String Symbol
		{
			get { return _symbol; }
		}

		public double Price
		{
			get { return _price; }
		}
	}
}