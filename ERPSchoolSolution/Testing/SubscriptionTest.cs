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
        private Subscription TestSubscription()
        {
            int newAmount = 40;
            int newId = 1;
            Student newStudent = new Student();
            Subscription aPayment = new Subscription();
            DateTime newDate = new DateTime();
            aPayment.Id = newId;
            aPayment.Student = newStudent;
            aPayment.Amount = newAmount;
            aPayment.Date = newDate;
            return aPayment;
        }
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
        [TestMethod]
        public void IsTheSameSubscriptionSuccess()
        {
            Subscription aPayment = TestSubscription();
            Subscription anotherPayment = TestSubscription();
            Assert.IsTrue(aPayment.IsTheSameSubscription(anotherPayment));
        }
        [TestMethod]
        public void IsTheSameSubscriptionFailStudent()
        {
            Subscription aPayment = TestSubscription();
            Subscription anotherPayment = TestSubscription();
            Student newStudent = new Student();
            newStudent.Id = 5;
            anotherPayment.Student = newStudent;
            Assert.IsFalse(aPayment.IsTheSameSubscription(anotherPayment));
        }

    }
}
