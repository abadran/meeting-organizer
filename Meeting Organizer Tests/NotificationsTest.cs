using Meeting_Organizer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Meeting_Organizer_Tests
{
    
    
    /// <summary>
    ///This is a test class for NotificationsTest and is intended
    ///to contain all NotificationsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NotificationsTest
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
        ///A test for Notifications Constructor
        ///</summary>
        [TestMethod()]
        public void NotificationsConstructorTest()
        {
            IEnumerable<Event> e = null; // TODO: Initialize to an appropriate value
            Notifications target = new Notifications(e);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for getEvent
        ///</summary>
        [TestMethod()]
        public void getEventTest()
        {
            IEnumerable<Event> e = null; // TODO: Initialize to an appropriate value
            Notifications target = new Notifications(e); // TODO: Initialize to an appropriate value
            int i = 0; // TODO: Initialize to an appropriate value
            Event expected = null; // TODO: Initialize to an appropriate value
            Event actual;
            actual = target.getEvent(i);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for events
        ///</summary>
        [TestMethod()]
        public void eventsTest()
        {
            IEnumerable<Event> e = null; // TODO: Initialize to an appropriate value
            Notifications target = new Notifications(e); // TODO: Initialize to an appropriate value
            IEnumerable<Event> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<Event> actual;
            target.events = expected;
            actual = target.events;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for numberOfNotifications
        ///</summary>
        [TestMethod()]
        public void numberOfNotificationsTest()
        {
            IEnumerable<Event> e = null; // TODO: Initialize to an appropriate value
            Notifications target = new Notifications(e); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.numberOfNotifications;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
