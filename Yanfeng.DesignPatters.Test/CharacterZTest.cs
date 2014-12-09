using FlyweightPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Yanfeng.DesignPatters.Test
{
    
    
    /// <summary>
    ///This is a test class for CharacterZTest and is intended
    ///to contain all CharacterZTest Unit Tests
    ///</summary>
	[TestClass()]
	public class CharacterZTest
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
		///A test for Display
		///</summary>
		[TestMethod()]
		public void DisplayTest()
		{
			// Build a document with text
			string document = "AAZZBBZB";
			char[] chars = document.ToCharArray();

			CharacterFactory factory = new CharacterFactory();

			// extrinsic state
			int pointSize = 10;

			// For each character use a flyweight object
			foreach (char c in chars)
			{
				pointSize++;
				Character character = factory.GetCharacter(c);
				character.Display(pointSize);
			}

			// Wait for user
			Console.ReadKey();
		}
	}
}
