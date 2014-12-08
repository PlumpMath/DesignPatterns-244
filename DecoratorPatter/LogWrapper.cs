namespace DecoratorPatter
{
	public abstract class LogWrapper: Log
	{
		private Log _log;

		public LogWrapper(Log log)
		{

			_log = log;

		}

		public override void Write(string log)
		{

			_log.Write(log);

		}
	}
}