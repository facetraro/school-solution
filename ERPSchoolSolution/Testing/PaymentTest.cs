using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using System.Diagnostics.CodeAnalysis;

namespace Testing
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class PaymentTest
    {
        [TestMethod]
        public void ComparePaymentSuccess()
        {
            Payment aPayment = new Payment();
            aPayment.Id = 123;
            aPayment.Student = new Student();
            aPayment.Amount = 40;
            Payment anotherPayment = new Payment();
            anotherPayment.Id = 123;
            anotherPayment.Student = new Student();
            anotherPayment.Amount = 40;
            Assert.IsTrue(aPayment.Equals(anotherPayment));
        }
        [TestMethod]
        public void ComparePaymentFail()
        {
            Payment aPayment = new Payment();
            aPayment.Id = 1;
            aPayment.Student = new Student();
            aPayment.Amount = 40;
            Payment anotherPayment = new Payment();
            anotherPayment.Id = 123;
            anotherPayment.Student = new Student();
            anotherPayment.Amount = 40;
            Assert.IsFalse(aPayment.Equals(anotherPayment));
        }
        [TestMethod]
        public void PaymentConstructor()
        {
            Payment aPayment = new Payment();
            aPayment.Id = 1;
            aPayment.Student = new Student();
            aPayment.Amount = 40;
            Assert.IsTrue(aPayment.Id.Equals(1));
            Assert.IsTrue(aPayment.Student.Equals(new Student()));
            Assert.IsTrue(aPayment.Amount.Equals(40));
        }
        [TestMethod]
        public void CompareDifferentObject()
        {
            Payment aPayment = new Payment();
            aPayment.Id = 1;
            aPayment.Student = new Student();
            aPayment.Amount = 40;
            int a = 5;
            Assert.IsFalse(aPayment.Equals(a));
        }
    }
}
