﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MementoPattern
{
	public class MementoTest
	{
		public void MementoTesting()
		{
			List<ContactPerson> persons = new List<ContactPerson>()
			{
				new ContactPerson() {Name = "Learning Hard", MobileNum = "123445"},
				new ContactPerson() {Name = "Tony", MobileNum = "234565"},
				new ContactPerson() {Name = "Jock", MobileNum = "231455"}
			};

			MobileOwner mobileOwner = new MobileOwner(persons);
			mobileOwner.Show();

			// 创建备忘录并保存备忘录对象
			Caretaker caretaker = new Caretaker();
			caretaker.ContactMementoDic.Add(DateTime.Now.ToString(), mobileOwner.CreateMemento());

			// 更改发起人联系人列表
			Console.WriteLine("----移除最后一个联系人--------");
			mobileOwner.ContactPersons.RemoveAt(2);
			mobileOwner.Show();

			// 创建第二个备份
			//Thread.Sleep(1000);
			caretaker.ContactMementoDic.Add(DateTime.Now.ToString(), mobileOwner.CreateMemento());

			// 恢复到原始状态
			Console.WriteLine("-------恢复联系人列表,请从以下列表选择恢复的日期------");
			var keyCollection = caretaker.ContactMementoDic.Keys;
			foreach (string k in keyCollection)
			{
				Console.WriteLine("Key = {0}", k);
			}
			int index = 0;

			while (index<2)
			{
				Console.Write("请输入数字,按窗口的关闭键退出:");

				try
				{
					index++;
					//index = Int32.Parse(Console.ReadLine());
				}
				catch
				{
					Console.WriteLine("输入的格式错误");
					continue;
				}

				ContactMemento contactMentor = null;
				if (index < keyCollection.Count && caretaker.ContactMementoDic.TryGetValue(keyCollection.ElementAt(index), out contactMentor))
				{
					mobileOwner.RestoreMemento(contactMentor);
					mobileOwner.Show();
				}
				else
				{
					Console.WriteLine("输入的索引大于集合长度！");
				}
			}
		}
	}
}
