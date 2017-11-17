using System;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class ActivityPaymentTest
    {
        [TestMethod]
        public void ActivityPaymentConstructor()
        {
            ActivityPayment anActivityPayment = new ActivityPayment();
            Student newStudent = new Student();
            Activity newActivity = new Activity();
            anActivityPayment.Id = 123;
            anActivityPayment.Student = new Student();
            anActivityPayment.Activity = new Activity();
            Assert.IsTrue(anActivityPayment.Id.Equals(123));
            Assert.IsTrue(anActivityPayment.Student.Equals(newStudent));
            Assert.IsTrue(anActivityPayment.Activity.Equals(newActivity));
        }
    }
}
