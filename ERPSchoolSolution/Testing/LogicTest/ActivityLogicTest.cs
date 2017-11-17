using System;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
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
        [TestMethod]
        public void AddActivityFail()
        {
            SetUp();
            Activity newActivity = new Activity();
            ActivityLogic testLogic = new ActivityLogic();
            Assert.IsFalse(testLogic.Exists(newActivity));
        }

    }
}
