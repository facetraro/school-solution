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
            anActivity.Id = 123;
            Activity anotherActivity = new Activity();
            anotherActivity.Id = 123;
            Assert.IsTrue(anActivity.Equals(anotherActivity));

         }
    }
}
