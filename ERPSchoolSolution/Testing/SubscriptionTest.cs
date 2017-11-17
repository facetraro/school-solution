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
        [TestMethod]
        public void IsTheSameSubscriptionFailYear()
        {
            Subscription aPayment = TestSubscription();
            Subscription anotherPayment = TestSubscription();
            DateTime newDate = new DateTime(2003, 4, 5, 4, 5, 6);
            anotherPayment.Date = newDate;
            Assert.IsFalse(aPayment.IsTheSameSubscription(anotherPayment));
        }
        [TestMethod]
        public void IsTheSameSubscriptionFailMonth()
        {
            Subscription aPayment = TestSubscription();
            Subscription anotherPayment = TestSubscription();
            DateTime newDate = new DateTime(2003, 7, 5, 4, 5, 6);
            DateTime anotherDate = new DateTime(2003, 4, 5, 4, 5, 6);
            aPayment.Date = newDate;
            anotherPayment.Date = anotherDate;
            Assert.IsFalse(aPayment.IsTheSameSubscription(anotherPayment));
        }
        [TestMethod]
        public void IsTheSameSubscriptionFailAmount()
        {
            Subscription aPayment = TestSubscription();
            Subscription anotherPayment = TestSubscription();
            int anotherAmount = 4239;
            anotherPayment.Amount = anotherAmount;
            Assert.IsFalse(aPayment.IsTheSameSubscription(anotherPayment));
        }
        [TestMethod]
        public void IsTheSameYearSuccess()
        {
            Subscription aPayment = TestSubscription();
            Subscription anotherPayment = TestSubscription();
            DateTime newDate = new DateTime(2003, 7, 5, 4, 5, 6);
            DateTime anotherDate = new DateTime(2003, 4, 5, 4, 5, 6);
            aPayment.Date = newDate;
            anotherPayment.Date = anotherDate;
            Assert.IsTrue(aPayment.IsTheSameYear(anotherPayment.Date));
        }
        [TestMethod]
        public void IsBeforeTrue()
        {
            Subscription aPayment = TestSubscription();
            Subscription anotherPayment = TestSubscription();
            DateTime firstDate = new DateTime(2003, 1, 5, 4, 5, 6);
            DateTime lastDate = new DateTime(2003, 4, 5, 4, 5, 6);
            aPayment.Date = firstDate;
            anotherPayment.Date = lastDate;
            Assert.IsTrue(aPayment.IsBefore(anotherPayment.Date));
        }
        [TestMethod]
        public void IsBeforeFalse()
        {
            Subscription aPayment = TestSubscription();
            Subscription anotherPayment = TestSubscription();
            DateTime firstDate = new DateTime(2003, 9, 5, 4, 5, 6);
            DateTime lastDate = new DateTime(2003, 4, 5, 4, 5, 6);
            aPayment.Date = firstDate;
            anotherPayment.Date = lastDate;
            Assert.IsFalse(aPayment.IsBefore(anotherPayment.Date));
        }
    }
}
