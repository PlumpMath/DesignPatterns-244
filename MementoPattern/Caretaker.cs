﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
	public class Caretaker
	{
		// 使用多个备忘录来存储多个备份点
		public Dictionary<string, ContactMemento> ContactMementoDic { get; set; }
		public Caretaker()
		{
			ContactMementoDic = new Dictionary<string, ContactMemento>();
		}
	}
}
