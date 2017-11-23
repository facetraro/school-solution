using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERPSchoolValidator;
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
        private void AddActivityToBD(Activity aActivity)
        {
            ActivityAccess logic = new ActivityAccess();
            logic.Add(aActivity);
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
        private Activity GetLastActivityInDB()
        {
            Activity testActivity = new Activity();
            ActivityLogic sLogic = new ActivityLogic();
            List<Activity> allActivity = sLogic.GetAllActivities();
            if (allActivity.Count != 0)
            {
                return allActivity.ElementAt(allActivity.Count - 1);
            }
            return testActivity;
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
        private Activity TestActivity()
        {
            Activity TestActivity = new Activity();
            int testId = 123;
            int testCost = 11;
            string testName = "testName";
            int yearDate = 2003;
            int monthDate = 1;
            int dayDate = 2;
            DateTime testDate = new DateTime(yearDate, monthDate, dayDate);
            TestActivity.Id = testId;
            TestActivity.Cost = testCost;
            TestActivity.Name = testName;
            TestActivity.Date = testDate;
            TestActivity.ActivityPayments = new List<ActivityPayment>();
            return TestActivity;
        }
        private void AddActivity()
        {
            Activity activity = TestActivity();
            this.AddActivityToBD(activity);
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

        private void AddActivityPayment()
        {
            AddActivity();
            AddStudentToDB(TestStudent());
            ActivityPayment payment = new ActivityPayment();
            payment.Activity = this.GetLastActivityInDB();
            payment.Student = this.GetLastStudentInDB();
            payment.Id = 500;
            ActivityPaymentAccess activityPaymentLogic = new ActivityPaymentAccess();
            activityPaymentLogic.Add(payment);
        }
        [TestMethod]
        public void GetAllPaymentsByStudentOnlyActivityPayment()
        {
            AddActivityPayment();
            PaymentLogic paymentLogic = new PaymentLogic();
            Assert.IsTrue(paymentLogic.GetAllPaymentsByStudent(GetLastStudentInDB()).Count == 1);
        }
    }
}
