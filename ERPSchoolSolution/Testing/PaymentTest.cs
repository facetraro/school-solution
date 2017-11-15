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
            Payment anotherPayment = new Payment();
            anotherPayment.Id = 123;
            anotherPayment.Student = new Student();
            Assert.IsTrue(aPayment.Equals(anotherPayment));
        }
        [TestMethod]
        public void ComparePaymentFail()
        {
            Payment aPayment = new Payment();
            aPayment.Id = 1;
            aPayment.Student = new Student();
            Payment anotherPayment = new Payment();
            anotherPayment.Id = 123;
            anotherPayment.Student = new Student();
            Assert.IsFalse(aPayment.Equals(anotherPayment));
        }
        [TestMethod]
        public void PaymentConstructor()
        {
            Payment aPayment = new Payment();
            aPayment.Id = 1;
            aPayment.Student = new Student();
            Assert.IsTrue(aPayment.Id.Equals(1));
            Assert.IsTrue(aPayment.Student.Equals(new Student()));
        }
        [TestMethod]
        public void CompareDifferentObjectPayment()
        {
            Payment aPayment = new Payment();
            aPayment.Id = 1;
            aPayment.Student = new Student();
            int anotherObject = 5;
            Assert.IsFalse(aPayment.Equals(anotherObject));
        }
    }
}
