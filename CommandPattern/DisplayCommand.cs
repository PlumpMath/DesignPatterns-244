namespace CommandPattern
{
	public class DisplayCommand:DocumentCommand
	{
		public DisplayCommand(Document doc) : base(doc)
		{
		}

		public override void Execute()
		{
			_document.Display();   
		}
	}
}