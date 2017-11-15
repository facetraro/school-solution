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
            Subscription aPayment = new Subscription();
            aPayment.Id = 1;
            aPayment.Student = new Student();
            aPayment.Amount = 40;
            aPayment.Date = new DateTime();
            Assert.IsTrue(aPayment.Id.Equals(1));
            Assert.IsTrue(aPayment.Student.Equals(new Student()));
            Assert.IsTrue(aPayment.Amount.Equals(40));
            Assert.IsTrue(aPayment.Date.Equals(new DateTime()));
        }
    }
}
