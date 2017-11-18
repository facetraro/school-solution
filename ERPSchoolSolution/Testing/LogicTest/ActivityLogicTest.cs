using System;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using System.Collections.Generic;
using System.Linq;

namespace Testing.LogicTest
{
    [TestClass]
    public class ActivityLogicTest : SetUpLogic
    {
        private Activity testActivity()
        {
            Activity testActivity = new Activity();
            int testId = 123;
            int testCost = 11;
            string testName = "testName";
            int yearDate = 2003;
            int monthDate = 1;
            int dayDate = 2;
            DateTime testDate = new DateTime(yearDate, monthDate, dayDate);
            testActivity.Id = testId;
            testActivity.Cost = testCost;
            testActivity.Name = testName;
            testActivity.Date = testDate;
            testActivity.ActivityPayments = new List<ActivityPayment>();
            return testActivity;
        }
        private Activity GetLastActivityInDB()
        {
            Activity anActivity = new Activity();
            ActivityLogic aLogic = new ActivityLogic();
            List<Activity> allActivitiesInDb = aLogic.GetAllActivities();
            if (allActivitiesInDb.Count != 0)
            {
                return allActivitiesInDb.ElementAt(allActivitiesInDb.Count - 1);
            }
            return testActivity();
        }
        [TestMethod]
        public void AddActivitySuccess()
        {
            SetUp();
            Activity newActivity = new Activity();
            DateTime aDate = new DateTime(2003, 4, 5, 4, 5, 6);
            newActivity.Date = aDate;
            ActivityLogic testLogic = new ActivityLogic();
            testLogic.Add(newActivity);
            newActivity.Id = GetLastActivityInDB().Id;
            Assert.IsTrue(testLogic.Exists(newActivity));
        }
        [TestMethod]
        public void AddActivityFail()
        {
            SetUp();
            Activity newActivity = new Activity();
            int testId = 122;
            newActivity.Id = testId;
            ActivityLogic testLogic = new ActivityLogic();
            Assert.IsFalse(testLogic.Exists(newActivity));
        }
        [TestMethod]
        public void RemoveActivitySuccess()
        {
            SetUp();
            ActivityLogic testLogic = new ActivityLogic();
            Activity anActivity = testActivity();
            testLogic.Add(anActivity);
            anActivity.Id = GetLastActivityInDB().Id;
            testLogic.Remove(anActivity);
            Assert.IsFalse(testLogic.Exists(anActivity));
        }
    }
}
