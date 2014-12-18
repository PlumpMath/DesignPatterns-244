using System.Collections.Generic;

namespace InterpreterPattern
{
	public class VarExpression:Expression
	{
		private string key;

		public VarExpression(string _key)
		{
			this.key = _key;
		}

		// 从map中取之  
		public override int interpreter(Dictionary<string, int> var)
		{
			return var[this.key];
		}
	}
}