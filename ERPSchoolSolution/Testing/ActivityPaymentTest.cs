using System;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class ActivityPaymentTest
    {
        private ActivityPayment TestActivityPayment()
        {
            int id = 123;
            Student aStudent = new Student();
            Activity anActivity = new Activity();
            ActivityPayment anActivityPayment = new ActivityPayment();
            anActivityPayment.Id = id;
            anActivityPayment.Student = aStudent;
            anActivityPayment.Activity = anActivity;
            return anActivityPayment;

        }

        [TestMethod]
        public void ActivityPaymentConstructor()
        {
            ActivityPayment anActivityPayment = new ActivityPayment();
            Student newStudent = new Student();
            Activity newActivity = new Activity();
            int testId = 123;
            anActivityPayment.Id = testId;
            anActivityPayment.Student = new Student();
            anActivityPayment.Activity = new Activity();
            Assert.IsTrue(anActivityPayment.Id.Equals(testId));
            Assert.IsTrue(anActivityPayment.Student.Equals(newStudent));
            Assert.IsTrue(anActivityPayment.Activity.Equals(newActivity));
        }
        [TestMethod]
        public void IsTheSameActivityPayment()
        {
            ActivityPayment anActivityPayment = TestActivityPayment();
            ActivityPayment anotherActivityPayment = TestActivityPayment();
            Assert.IsTrue(anActivityPayment.IsTheSameActivityPayment(anotherActivityPayment));
        }
    }
}
