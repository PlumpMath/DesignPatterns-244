using System.Collections.Generic;

namespace InterpreterPattern
{
	public class Calculator
	{
		// 定义的表达式  
		private Expression expression;

		// 构造函数传参,并解析  
		public Calculator(string expStr)
		{
			// 定义一个堆栈，安排运算的先后顺序  
			Stack<Expression> stack = new Stack<Expression>();
			// 表达式拆分为字符数组  
			char[] charArray = expStr.ToCharArray();
			// 运算  
			Expression left = null;
			Expression right = null;
			for (int i = 0; i < charArray.Length; i++)
			{
				switch (charArray[i])
				{
					case '+': // 加法  
						// 加法结果放到堆栈中  
						left = stack.Pop();
						right = new VarExpression(charArray[++i].ToString());
						stack.Push(new AddExpression(left, right));
						break;
					case '-':
						left = stack.Pop();
						right = new VarExpression(charArray[++i].ToString());
						stack.Push(new SubExpression(left, right));
						break;
					default: // 公式中的变量  
						stack.Push(new VarExpression(charArray[i].ToString()));
						break;
				}
			}
			// 把运算结果抛出来  
			this.expression = stack.Pop();
		}

		// 开始运算  
		public int run(Dictionary<string, int> var)
		{
			return this.expression.interpreter(var);
		}   
	}
}