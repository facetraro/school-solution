using System;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing.LogicTest
{
    [TestClass]
    public class ActivityLogicTest : SetUpLogic
    {
        [TestMethod]
        public void AddActivitySuccess()
        {
            SetUp();
            Activity newActivity = new Activity();
            ActivityLogic testLogic = new ActivityLogic();
            testLogic.Add(newActivity);
            Assert.IsTrue(testLogic.Exists(newActivity));
        }
    }
}
