using HSDemo.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace HSDemo.Tests
{
    
    
    /// <summary>
    ///This is a test class for FizzBuzzHeperTest and is intended
    ///to contain all FizzBuzzHeperTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NumberGeneratorTests
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
        //Test method without number-to-message configuration
        ///</summary>
        [TestMethod()]
        public void GenerateFizzBuzzTestTotalRecords()
        {
      
            int expected = 100;
            int actual = 0;

            var objNumberGenerator = new NumberGenerator();
            actual = objNumberGenerator.GenerateNumberList(null).CountPrintedValues;

            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        //Test method with min and max values and number-to-message configuration
        ///</summary>
        [TestMethod()]
        public void GenerateFizzBuzzTestTotalRecordsWithMessages()
        {
            var dicNumberToMessage = new Dictionary<int, string>();
            dicNumberToMessage.Add(2, "Message for number two.");
            dicNumberToMessage.Add(3, "Message for number three.");
            dicNumberToMessage.Add(8, "Message for number eigth.");

            int minValue, maxValue;
            minValue = 0;
            maxValue = 250;

            int expected = maxValue - minValue + 1;
            int actual = 0;

            var objNumberGenerator = new NumberGenerator();
            actual = objNumberGenerator.GenerateNumberList(dicNumberToMessage, minValue, maxValue).CountPrintedValues;

            Assert.AreEqual(expected, actual);
        }

        //Removed this test method as IsFizzPrintedFor3 does not exists anymore.
        //[TestMethod()]
        //public void GenerateFizzBuzzTestFizzPrintedFor3()
        //{
        //    var fbh = new FizzBuzzHeper();
        //    bool expected = true;
        //    bool actual = false;
        //    actual = fbh.GenerateFizzBuzz().IsFizzPrintedFor3;
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
