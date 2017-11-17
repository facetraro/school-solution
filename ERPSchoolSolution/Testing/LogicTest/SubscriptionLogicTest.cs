using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Logic;
using System.Collections.Generic;
using System.Linq;
using Exceptions;
using System.Diagnostics.CodeAnalysis;
using Repository;
using System;

namespace Testing.LogicTest
{
    [TestClass]
    [ExcludeFromCodeCoverage]

    public class SubscrptionLogicTest : SetUpLogic
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
        private Student GetLastStudentInDB()
        {
            Student testStudent = new Student();
            StudentLogic sLogic = new StudentLogic();
            List<Student> allStudentsInDB = sLogic.GetAllStudents();
            if (allStudentsInDB.Count!=0)
            {
                return allStudentsInDB.ElementAt(allStudentsInDB.Count-1);
            }
            return testStudent;
        }
        private Subscription TestSubscription()
        {
            Subscription newSub = new Subscription();
            AddStudentToDB(TestStudent());
            newSub.Amount = 400;
            newSub.Date = new DateTime(2003, 4, 5, 4, 5, 6);
            newSub.Student = GetLastStudentInDB();
            return newSub;
        }
        [TestMethod]
        public void AddSubscriptionSuccess()
        {
            SetUp();
            Subscription newSub=TestSubscription();
            SubscriptionLogic logic = new SubscriptionLogic();
            logic.Add(newSub);
            Assert.IsTrue(logic.Exists(newSub));
        }
        [TestMethod]
        public void ExistsFail()
        {
            SetUp();
            Subscription newSub = TestSubscription();
            SubscriptionLogic logic = new SubscriptionLogic();
            Assert.IsFalse(logic.Exists(newSub));
        }
    }
}
