namespace CommandPattern
{
	public class UndoCommand:DocumentCommand
	{
		public UndoCommand(Document doc) : base(doc)
		{
		}

		public override void Execute()
		{
			_document.Undo();
		}
	}
}