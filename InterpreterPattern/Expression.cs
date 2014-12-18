using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
	public abstract class Expression
	{// 解析公式和数值,其中var中的key值是是公式中的参数，value值是具体的数字  

		public abstract int interpreter(Dictionary<string,int> var);  
    }
}
