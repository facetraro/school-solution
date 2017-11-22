using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Logic;
using System.Collections.Generic;
using System.Linq;
using Exceptions;
using System.Diagnostics.CodeAnalysis;
using Repository;

namespace Testing.LogicTest
{
    [TestClass]
    [ExcludeFromCodeCoverage]

    public class PaymentLogicTest : SetUpLogic
    {
        private Student TestStudent()
        {
            Student testStudent = new Student();
            testStudent.Ci = 47803333;
            testStudent.Id = 123;
            testStudent.StudentNumber = 123;
            testStudent.Name = "TestName";
            testStudent.LastName = "TestLastName";

            return testStudent;
        }
        private void AddStudentToDB(Student aStudent)
        {
            StudentAccess logic = new StudentAccess();
            logic.Add(aStudent);
        }
        private Student GetLastStudentInDB()
        {
            Student testStudent = new Student();
            StudentLogic sLogic = new StudentLogic();
            List<Student> allStudentsInDB = sLogic.GetAllStudents();
            if (allStudentsInDB.Count != 0)
            {
                return allStudentsInDB.ElementAt(allStudentsInDB.Count - 1);
            }
            return testStudent;
        }
        private void AddTestSubscription()
        {
            Subscription newSub = new Subscription();
            AddStudentToDB(TestStudent());
            newSub.Amount = 400;
            newSub.Date = new DateTime(2017, 11, 2);
            newSub.Student = GetLastStudentInDB();
            SubscriptionLogic subscriptionLogic = new SubscriptionLogic();
            subscriptionLogic.Add(newSub);
        }
        [TestMethod]
        public void GetAllPaymentsOnlySubscriptions()
        {
            AddTestSubscription();
            PaymentLogic paymentLogic = new PaymentLogic();
            Assert.IsTrue(paymentLogic.GetAllPayments().Count==1); 
        }
        [TestMethod]
        public void GetAllPaymentsByStudentEmpty()
        {
            AddTestSubscription();
            PaymentLogic paymentLogic = new PaymentLogic();
            Student newStudent = new Student();
            Assert.IsTrue(paymentLogic.GetAllPaymentsByStudent(newStudent).Count == 0);
        }
        [TestMethod]
        public void GetAllPaymentsByStudentOnlySubscription()
        {
            AddTestSubscription();
            PaymentLogic paymentLogic = new PaymentLogic();
            Assert.IsTrue(paymentLogic.GetAllPaymentsByStudent(GetLastStudentInDB()).Count == 1);
        }
    }
}
