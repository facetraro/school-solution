using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;

namespace Testing.LogicTest
{
    [TestClass]
    public class ActivityPaymentLogicTest : SetUpLogic
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
            StudentAccess context = new StudentAccess();
            context.Add(aStudent);
        }
        private Activity TestActivity()
        {
            Activity testActivity = new Activity();
            testActivity.Name = "testName";
            testActivity.Id = 123;
            testActivity.Cost = 123;
            testActivity.Name = "TestName";
            testActivity.Date = new DateTime(2013, 12, 12);
            testActivity.ActivityPayments = new List<ActivityPayment>();
            return testActivity;
        }
        private void AddActivityToBd(Activity anActivity)
        {
            ActivityAccess context = new ActivityAccess();
            context.Add(anActivity);
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
        private Activity GetLastActivityInBd()
        {
            Activity testActivity = new Activity();
            ActivityLogic sLogic = new ActivityLogic();
            List<Activity> allActivitiesInBd = sLogic.GetAllActivities();
            if (allActivitiesInBd.Count != 0)
            {
                return allActivitiesInBd.ElementAt(allActivitiesInBd.Count - 1);
            }
            return testActivity;
        }
        private ActivityPayment TestActivityPayment()
        {
            ActivityPayment newActPay = new ActivityPayment();
            AddStudentToDB(TestStudent());
            AddActivityToBd(TestActivity());
            newActPay.Id = 12;
            newActPay.Activity = GetLastActivityInBd();
            newActPay.Student = GetLastStudentInDB();
            return newActPay;
        }
        [TestMethod]
        public void AddActivityPaymentSuccess()
        {
            SetUp();
            ActivityPayment newActPay = TestActivityPayment();
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
