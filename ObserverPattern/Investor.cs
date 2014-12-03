using System;

namespace ObserverPattern
{
	public class Investor : IObserver
	{
		private string _name;

		public Investor(string name)
		{
			this._name = name;
		}

		#region IObserver Members

		public void SendData(Stock stock)
		{
			Console.WriteLine("Notified {0} of {1}'s " + "change to {2:C}", _name, stock.Symbol, stock.Price);
		}

		#endregion
	}
}