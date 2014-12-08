using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public abstract class DocumentCommand
    {
		protected Document _document;

	    public DocumentCommand(Document doc)
		{
			this._document = doc;
		}

		/// <summary>

		/// 执行

		/// </summary>

		public abstract void Execute();

    }
}
