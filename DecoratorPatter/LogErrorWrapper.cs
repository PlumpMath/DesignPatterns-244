using System;

namespace DecoratorPatter
{
	public class LogErrorWrapper:LogWrapper
	{
		public LogErrorWrapper(Log log) : base(log)
		{
		}

		public override void Write(string log)
		{

			SetError(); //......功能扩展

			base.Write(log);

		}

		private void SetError()
		{
			Console.WriteLine("Error set");
			//......实现了记录错误严重级别

		}

	}
}