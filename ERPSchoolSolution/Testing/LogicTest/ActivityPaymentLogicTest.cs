using System;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing.LogicTest
{
    [TestClass]
    public class ActivityPaymentLogicTest
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
    }
}
