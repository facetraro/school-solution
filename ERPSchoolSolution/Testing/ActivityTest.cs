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
    }
}
