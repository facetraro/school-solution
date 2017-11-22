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
            newSub.Date = new DateTime(2017, 11, 2);
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
        public void ExistsSubscriptionFail()
        {
            SetUp();
            Subscription newSub = TestSubscription();
            SubscriptionLogic logic = new SubscriptionLogic();
            Assert.IsFalse(logic.Exists(newSub));
        }
        [TestMethod]
        [ExpectedException(typeof(AlreadySubscriptedException))]
        public void AddAlreadySubscriptedDateStudent()
        {
            SetUp();
            Subscription newSub = TestSubscription();
            SubscriptionLogic logic = new SubscriptionLogic();
            logic.Add(newSub);
            logic.Add(newSub);
            Assert.IsTrue(logic.Lenght()==1);
        }
        [TestMethod]
        public void SusbscriptionLenght0()
        {
            SetUp();
            Subscription newSub = TestSubscription();
            SubscriptionLogic logic = new SubscriptionLogic();
            Assert.IsTrue(logic.Lenght() == 0);
        }
        [TestMethod]
        [ExpectedException(typeof(StudentNotUpToDateException))]
        public void AddStudentNotUpToDate()
        {
            SetUp();
            Subscription firstSub = TestSubscription();
            Subscription secondSub = TestSubscription();
            Subscription thirdSub = TestSubscription();
            secondSub.Date = firstSub.Date.AddMonths(1);
            thirdSub.Date = secondSub.Date.AddMonths(3);
            SubscriptionLogic logic = new SubscriptionLogic();
            logic.Add(firstSub);
            logic.Add(secondSub);
            logic.Add(thirdSub);
            Assert.IsTrue(logic.Lenght() == 2);
        }
        [TestMethod]
        public void AddAnotherStudentPayment()
        {
            SetUp();
            Subscription firstSub = TestSubscription();
            Subscription secondSub = TestSubscription();
            SubscriptionLogic logic = new SubscriptionLogic();
            logic.Add(firstSub);
            Student anotherStudent = TestStudent();
            anotherStudent.Ci = 47801210;
            anotherStudent.StudentNumber = 654;
            AddStudentToDB(anotherStudent);
            secondSub.Student = GetLastStudentInDB();
            logic.Add(secondSub);
            Assert.IsTrue(logic.Lenght() == 2);
        }
        [TestMethod]
        [ExpectedException(typeof(StudentNotUpToDateException))]
        public void AddInvalidStudentPayment()
        {
            SetUp();
            Subscription firstSub = TestSubscription();
            firstSub.Date = firstSub.Date.AddMonths(1);
            SubscriptionLogic logic = new SubscriptionLogic();
            logic.Add(firstSub);
            Assert.IsTrue(logic.Lenght() == 0);
        }
    }
}
