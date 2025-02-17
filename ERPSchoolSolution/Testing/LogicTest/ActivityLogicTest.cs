﻿using System;
using ERPSchoolValidator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using System.Collections.Generic;
using System.Linq;
using Exceptions;

namespace Testing.LogicTest
{
    [TestClass]
    public class ActivityLogicTest : SetUpLogic
    {
        private Activity testActivity()
        {
            Activity TestActivity = new Activity();
            int testId = 123;
            int testCost = 11;
            string testName = "testName";
            int yearDate = 2003;
            int monthDate = 1;
            int dayDate = 2;
            DateTime testDate = new DateTime(yearDate, monthDate, dayDate);
            TestActivity.Id = testId;
            TestActivity.Cost = testCost;
            TestActivity.Name = testName;
            TestActivity.Date = testDate;
            TestActivity.ActivityPayments = new List<ActivityPayment>();
            return TestActivity;
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
            int id = GetLastActivityInDB().Id;
            anActivity.Id = GetLastActivityInDB().Id;
            testLogic.Remove(anActivity);
            Assert.IsFalse(testLogic.Exists(anActivity));
        }
        [TestMethod]
        public void ModifyActivitySuccess()
        {
            SetUp();
            ActivityLogic testLogic = new ActivityLogic();
            Activity newActivity = testActivity();
            Activity anotherActivity = testActivity();
            string testName = "newName";
            anotherActivity.Name = testName;
            testLogic.Add(newActivity);
            anotherActivity.Id = GetLastActivityInDB().Id;
            testLogic.Modify(newActivity, anotherActivity);
            List<Activity> list = testLogic.GetAllActivities();
            bool validation = false;
            if (list.Count != 0)
            {
                validation = (list.ElementAt(0).Name == anotherActivity.Name);
            }
            Assert.IsTrue(validation);
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyOrNullValueException))]
        public void ModifyStudentFailCheckOldActivity()
        {
            SetUp();
            ActivityLogic testLogic = new ActivityLogic();
            Activity newActivity = testActivity();
            Activity anotherActivity = testActivity();
            anotherActivity.Name = "";
            anotherActivity.Cost = -3;
            testLogic.Add(newActivity);
            newActivity.Id = GetLastActivityInDB().Id;
            testLogic.Modify(newActivity, anotherActivity);
            Assert.IsTrue(testLogic.Exists(newActivity));
        }
    }
}
