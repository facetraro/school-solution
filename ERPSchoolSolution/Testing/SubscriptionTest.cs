using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using System.Diagnostics.CodeAnalysis;

namespace Testing
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class SubscriptionTest
    {
        [TestMethod]
        public void SubscriptionConstructor()
        {
            DateTime newDate = new DateTime();
            int newAmount = 40;
            int newId = 1;
            Student newStudent = new Student();
            Subscription aPayment = new Subscription();
            aPayment.Id = newId;
            aPayment.Student = newStudent;
            aPayment.Amount = newAmount;
            aPayment.Date = newDate;
            Assert.IsTrue(aPayment.Id.Equals(newId));
            Assert.IsTrue(aPayment.Student.Equals(newStudent));
            Assert.IsTrue(aPayment.Amount.Equals(newAmount));
            Assert.IsTrue(aPayment.Date.Equals(newDate));
        }

    }
}
