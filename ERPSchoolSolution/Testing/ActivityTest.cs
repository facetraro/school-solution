using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Exceptions;

namespace Testing
{
    [TestClass]
    public class ActivityTest
    {
        [TestMethod]
        public void CompareActivitySuccess()
        {
            Activity anActivity = new Activity();
            int id = 123;
            anActivity.Id = id;
            Activity anotherActivity = new Activity();
            anotherActivity.Id = id;
            Assert.IsTrue(anActivity.Equals(anotherActivity));
        }
        [TestMethod]
        public void CompareActivityFail()
        {
            Activity anActivity = new Activity();
            int id = 123;
            int anotherId = 124;
            anActivity.Id = id;
            Activity anotherActivity = new Activity();
            anotherActivity.Id = anotherId;
            Assert.IsFalse(anActivity.Equals(anotherActivity));
        }
        [TestMethod]
        public void ActivityConstructorTest()
        {
            Activity anActivity = new Activity();
            int testId = 123;
            string testName = "testName";
            DateTime activityDate = new DateTime();
            int costTest = 1000;
            anActivity.Id = testId;
            anActivity.Name = testName;
            anActivity.Date = new DateTime();
            anActivity.Cost = costTest;
            Assert.IsTrue(anActivity.Id.Equals(testId));
            Assert.IsTrue(anActivity.Name.Equals(testName));
            Assert.IsTrue(anActivity.Date.Equals(activityDate));
            Assert.IsTrue(anActivity.Cost.Equals(costTest));
        }
        [TestMethod]
        public void CompareActivityNull()
        {
            int testInt = 3;
            Activity anActivity = new Activity();
            Assert.IsFalse(anActivity.Equals(testInt));
        }

        [TestMethod]
        public void IsValidActivityIdSuccess()
        {
            Activity anActivity = new Activity();
            int testId = 12;
            string testName = "testName";
            int testCost = 1000;
            anActivity.Id = testId;
            anActivity.Name = testName;
            DateTime activityDate = new DateTime();
            anActivity.Date = activityDate;
            anActivity.Cost = testCost;
            ActivityValidator validator = new ActivityValidator();
            Assert.IsTrue(validator.IsValid(anActivity));
        }
        [TestMethod]
        [ExpectedException(typeof(EmptyOrNullValueException))]
        public void IsValidActivityFail()
        {
            Activity anActivity = new Activity();
            ActivityValidator validator = new ActivityValidator();
            Assert.IsFalse(validator.IsValid(anActivity));
        }
        [TestMethod]
        [ExpectedException(typeof(EmptyOrNullValueException))]
        public void IsValidNameSuccess()
        {
            string testName = "";
            Activity anActivity = new Activity();
            anActivity.Name = testName;
            int testId = 123;
            anActivity.Id = testId;
            ActivityValidator validator = new ActivityValidator();
            Assert.IsFalse(validator.IsValid(anActivity));
        }
        [TestMethod]
        [ExpectedException(typeof(EmptyOrNullValueException))]
        public void IsValidCostSuccess()
        {
            string testName = "testName";
            Activity anActivity = new Activity();
            anActivity.Name = testName;
            int testId = 123;
            anActivity.Id = testId;
            ActivityValidator validator = new ActivityValidator();
            Assert.IsTrue(validator.IsValid(anActivity));
        }
    }
}
