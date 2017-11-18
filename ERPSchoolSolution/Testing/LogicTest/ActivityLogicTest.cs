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
            testActivity.Id = 123;
            testActivity.Cost = 11;
            testActivity.Name = "testName";
            testActivity.Date = new DateTime(2003, 1, 2, 3, 4, 50);
            testActivity.ActivityPayments = new List<ActivityPayment>();
            return testActivity;
        }
        private Activity GetLastActivityInDB()
        {
            Activity anActivity= new Activity();
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
            DateTime aDate = new DateTime(2003,4,5,4,5,6);
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
            newActivity.Id = 122;
            ActivityLogic testLogic = new ActivityLogic();
            Assert.IsFalse(testLogic.Exists(newActivity));
        }

    }
}
