namespace FactoryMethod
{
	public class EventFactory:LogFactory
	{
		public override Log Create()
		{
			return new EventLog();
		}
	}
}