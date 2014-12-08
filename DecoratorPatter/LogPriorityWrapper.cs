using System;

namespace DecoratorPatter
{
	public class LogPriorityWrapper:LogWrapper
	{
		public LogPriorityWrapper(Log log) : base(log)
		{
		}

		public override void Write(string log)
		{

			SetPriority(); //......功能扩展
			base.Write(log);

		}

		public void SetPriority()
		{
			Console.WriteLine("Priority set");
			//......实现了记录优先级别

		}
	}
}