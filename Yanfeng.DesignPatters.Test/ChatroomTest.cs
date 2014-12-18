using Mediator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Yanfeng.DesignPatters.Test
{
    
    
    /// <summary>
    ///This is a test class for ChatroomTest and is intended
    ///to contain all ChatroomTest Unit Tests
    ///</summary>
	[TestClass()]
	public class ChatroomTest
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
		///A test for Send
		///</summary>
		[TestMethod()]
		public void SendTest()
		{
			// Create chatroom
			Chatroom chatroom = new Chatroom();

			// Create participants and register them
			Participant George = new Beatle("George");
			Participant Paul = new Beatle("Paul");
			Participant Ringo = new Beatle("Ringo");
			Participant John = new Beatle("John");
			Participant Yoko = new NonBeatle("Yoko");

			chatroom.Register(George);
			chatroom.Register(Paul);
			chatroom.Register(Ringo);
			chatroom.Register(John);
			chatroom.Register(Yoko);

			// Chatting participants
			Yoko.Send("John", "Hi John!");
			Paul.Send("Ringo", "All you need is love");
			Ringo.Send("George", "My sweet Lord");
			Paul.Send("John", "Can't buy me love");
			John.Send("Yoko", "My sweet love");

			// Wait for user
			//Console.ReadKey();
		}

		/// <summary>
		///A test for Register
		///</summary>
		[TestMethod()]
		public void RegisterTest()
		{
			Chatroom target = new Chatroom(); // TODO: Initialize to an appropriate value
			Participant participant = null; // TODO: Initialize to an appropriate value
			target.Register(participant);
			Assert.Inconclusive("A method that does not return a value cannot be verified.");
		}

		/// <summary>
		///A test for Chatroom Constructor
		///</summary>
		[TestMethod()]
		public void ChatroomConstructorTest()
		{
			Chatroom target = new Chatroom();
			Assert.Inconclusive("TODO: Implement code to verify target");
		}
	}
}
