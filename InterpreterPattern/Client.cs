using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
	class Client
	{
		public static void Main()
		{
			String expStr = getExpStr();
			// 赋值  
			Dictionary<string, int> var = getValue(expStr);
			Calculator cal = new Calculator(expStr);
			Console.WriteLine("运算结果为：" + expStr + "=" + cal.run(var));
		}

		// 获得表达式  
		public static String getExpStr()
		{
			Console.WriteLine("请输入表达式：");
			return (Console.ReadLine());
		}

		public static Dictionary<string, int> getValue(String exprStr)
		{
			Dictionary<string, int> map = new Dictionary<string, int>();
			// 解析有几个参数要传递  

			foreach (char ch in exprStr.ToCharArray())
			{
				if (ch != '+' && ch != '-')
				{
					// 解决重复参数的问题  
					if (!map.ContainsKey(ch.ToString()))
					{
						Console.WriteLine("请输入" + ch + "的值:");
						String in2 = Console.ReadLine();
						map.Add(ch.ToString(), int.Parse(in2));
					}
				}
			}
			return map;
		}
	}
}
