namespace CommandPattern
{
	public class RedoCommand:DocumentCommand
	{
		public RedoCommand(Document doc) : base(doc)
		{
		}

		public override void Execute()
		{
			_document.Redo();
		}
	}
}