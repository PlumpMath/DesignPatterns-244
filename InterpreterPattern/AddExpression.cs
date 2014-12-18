using System.Collections.Generic;

namespace InterpreterPattern
{
	public class AddExpression:SymbolExpression
	{
		public AddExpression(Expression _left, Expression _right) : base(_left, _right)
		{

		}

		// 把左右两个表达式运算的结果加起来  
		public override int interpreter(Dictionary<string, int> var)
		{
			return base.left.interpreter(var) + base.right.interpreter(var);
		} 
	}
}