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
            anActivity.Id = 123;
            Activity anotherActivity = new Activity();
            anotherActivity.Id = 124;
            Assert.IsFalse(anActivity.Equals(anotherActivity));
        }
    }
}
