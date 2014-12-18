using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
	public class ContactMemento
	{
		public List<ContactPerson> ContactPersonBack { get; set; }
		public ContactMemento(List<ContactPerson> persons)
		{
			ContactPersonBack = persons;
		}
	}
}
