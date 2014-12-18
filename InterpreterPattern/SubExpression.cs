using System;
using System.Collections.Generic;

namespace InterpreterPattern
{
	public class SubExpression:SymbolExpression
	{

		// 左右两个表达式相减  
		public SubExpression(Expression _left, Expression _right) : base(_left, _right)
		{
		}

		public override int interpreter(Dictionary<string, int> var)
		{
			return base.left.interpreter(var) - base.right.interpreter(var);
		}   
	}
}