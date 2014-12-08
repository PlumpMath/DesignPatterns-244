﻿namespace CommandPattern
{
	public class DocumentInvoker
	{
		DocumentCommand _discmd;

		DocumentCommand _undcmd;

		DocumentCommand _redcmd;

		public DocumentInvoker(DocumentCommand discmd, DocumentCommand undcmd, DocumentCommand redcmd)
		{

			this._discmd = discmd;

			this._undcmd = undcmd;

			this._redcmd = redcmd;

		}

		public void Display()
		{
			_discmd.Execute();
		}

		public void Undo()
		{
			_undcmd.Execute();
		}

		public void Redo()
		{
			_redcmd.Execute();
		} 
	}
}