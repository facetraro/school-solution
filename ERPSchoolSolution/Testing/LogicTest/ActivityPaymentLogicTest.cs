using System;
using Domain;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing.LogicTest
{
    [TestClass]
    public class ActivityPaymentLogicTest : SetUpLogic
    {
        [TestMethod]
        public void AddActivityPaymentSuccess()
        {
            SetUp();
            ActivityPayment newActPay = new ActivityPayment();
            ActivityPaymentLogic logic = new ActivityPaymentLogic();
            logic.Add(newActPay);
            Assert.IsTrue(logic.Exists(newActPay));
        }
        [TestMethod]
        public void ExistsActivityPaymentFail()
        {
            SetUp();
            ActivityPayment newActPay = new ActivityPayment();
            ActivityPaymentLogic logic = new ActivityPaymentLogic();
            Assert.IsFalse(logic.Exists(newActPay));
        }
    }
}
