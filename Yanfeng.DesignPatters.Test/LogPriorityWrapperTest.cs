using DecoratorPatter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Yanfeng.DesignPatters.Test
{
    
    
    /// <summary>
    ///This is a test class for LogPriorityWrapperTest and is intended
    ///to contain all LogPriorityWrapperTest Unit Tests
    ///</summary>
	[TestClass()]
	public class LogPriorityWrapperTest
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
		///A test for Write
		///</summary>
		[TestMethod()]
		public void WriteTest()
		{
			Log log = new DatabaseLog();

			LogWrapper lew2 = new LogErrorWrapper(log);

			LogPriorityWrapper lpw2 = new LogPriorityWrapper(lew2); //这里是lew2

			//同时扩展了错误严重级别和优先级别

			lpw2.Write("Log Message");

			//Log log = null; // TODO: Initialize to an appropriate value
			//LogPriorityWrapper target = new LogPriorityWrapper(log); // TODO: Initialize to an appropriate value
			//string log1 = string.Empty; // TODO: Initialize to an appropriate value
			//target.Write(log1);
			//Assert.Inconclusive("A method that does not return a value cannot be verified.");
		}
	}
}
