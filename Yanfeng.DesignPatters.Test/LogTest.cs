using System.Configuration;
using System.Reflection;
using FactoryMethod;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Yanfeng.DesignPatters.Test
{
    
    
    /// <summary>
    ///This is a test class for LogTest and is intended
    ///to contain all LogTest Unit Tests
    ///</summary>
	[TestClass()]
	public class LogTest
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
		//LogFactory factory = new EventFactory();

		//Log log = factory.Create();

		//log.Write();

			 string strfactoryName = ConfigurationSettings.AppSettings["factoryName"];
        
        LogFactory factory;
        factory = (LogFactory)Assembly.Load("FactoryMethod").CreateInstance("FactoryMethod." + strfactoryName);

       Log log = factory.Create();
       log.Write();
		}
	}
}
