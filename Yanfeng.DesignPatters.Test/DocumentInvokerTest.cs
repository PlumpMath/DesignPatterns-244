using CommandPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Yanfeng.DesignPatters.Test
{
    
    
    /// <summary>
    ///This is a test class for DocumentInvokerTest and is intended
    ///to contain all DocumentInvokerTest Unit Tests
    ///</summary>
	[TestClass()]
	public class DocumentInvokerTest
	{


		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		// 
		//You can use the following additional attributes as you write your tests:
		//
		//Use ClassInitialize to run code before running the first test in the class
		//[ClassInitialize()]
		//public static void MyClassInitialize(TestContext testContext)
		//{
		//}
		//
		//Use ClassCleanup to run code after all tests in a class have run
		//[ClassCleanup()]
		//public static void MyClassCleanup()
		//{
		//}
		//
		//Use TestInitialize to run code before running each test
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{
		//}
		//
		//Use TestCleanup to run code after each test has run
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{
		//}
		//
		#endregion


		/// <summary>
		///A test for Undo
		///</summary>
		[TestMethod()]
		public void UndoTest()
		{
			DocumentCommand discmd = null; // TODO: Initialize to an appropriate value
			DocumentCommand undcmd = null; // TODO: Initialize to an appropriate value
			DocumentCommand redcmd = null; // TODO: Initialize to an appropriate value
			DocumentInvoker target = new DocumentInvoker(discmd, undcmd, redcmd); // TODO: Initialize to an appropriate value
			target.Undo();
			Assert.Inconclusive("A method that does not return a value cannot be verified.");
		}

		/// <summary>
		///A test for Redo
		///</summary>
		[TestMethod()]
		public void RedoTest()
		{
			DocumentCommand discmd = null; // TODO: Initialize to an appropriate value
			DocumentCommand undcmd = null; // TODO: Initialize to an appropriate value
			DocumentCommand redcmd = null; // TODO: Initialize to an appropriate value
			DocumentInvoker target = new DocumentInvoker(discmd, undcmd, redcmd); // TODO: Initialize to an appropriate value
			target.Redo();
			Assert.Inconclusive("A method that does not return a value cannot be verified.");
		}

		/// <summary>
		///A test for Display
		///</summary>
		[TestMethod()]
		public void DisplayTest()
		{
			Document doc = new Document();


			DocumentCommand discmd = new DisplayCommand(doc);

			DocumentCommand undcmd = new UndoCommand(doc);

			DocumentCommand redcmd = new RedoCommand(doc);


			DocumentInvoker invoker = new DocumentInvoker(discmd, undcmd, redcmd);

			invoker.Display();

		}
	}
}
