using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
	public class MobileOwner
	{
		public List<ContactPerson> ContactPersons { get; set; }
		public MobileOwner(List<ContactPerson> persons)
		{
			ContactPersons = persons;
		}

		// 创建备忘录，将当期要保存的联系人列表导入到备忘录中 
		public ContactMemento CreateMemento()
		{
			return new ContactMemento(new List<ContactPerson>(this.ContactPersons));
		}

		// 将备忘录中的数据备份导入到联系人列表中
		public void RestoreMemento(ContactMemento memento)
		{
			if (memento != null)
			{
				this.ContactPersons = memento.ContactPersonBack;
			}
		}
		public void Show()
		{
			Console.WriteLine("联系人列表中有{0}个人，他们是:", ContactPersons.Count);
			foreach (ContactPerson p in ContactPersons)
			{
				Console.WriteLine("姓名: {0} 号码为: {1}", p.Name, p.MobileNum);
			}
		}
	}
}
