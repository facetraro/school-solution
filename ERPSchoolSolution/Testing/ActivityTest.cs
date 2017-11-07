using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
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
            anActivity.Id = 123;
            anActivity.Name = "testName";
            DateTime activityDate = new DateTime();
            anActivity.Date = new DateTime();
            anActivity.Cost = 1000;
            Assert.IsTrue(anActivity.Id.Equals(123));
            Assert.IsTrue(anActivity.Name.Equals("testName"));
            Assert.IsTrue(anActivity.Date.Equals(activityDate));
            Assert.IsTrue(anActivity.Cost.Equals(1000));
        }
    }
}
