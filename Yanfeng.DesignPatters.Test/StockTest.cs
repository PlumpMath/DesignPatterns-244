using ObserverPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Yanfeng.DesignPatters.Test
{
    
    
    /// <summary>
    ///This is a test class for StockTest and is intended
    ///to contain all StockTest Unit Tests
    ///</summary>
	[TestClass()]
	public class StockTest
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


		internal virtual Stock CreateStock()
		{
			// TODO: Instantiate an appropriate concrete class.
			Stock target = null;
			return target;
		}

		/// <summary>
		///A test for Update
		///</summary>
		[TestMethod()]
		public void UpdateTest()
		{
			Stock ms = new MicroSoft("Microsoft", 120.00);

			ms.AddObserver(new Investor("Jom"));

			ms.AddObserver(new Investor("TerryLee"));

			ms.Update();
		}
	}
}
