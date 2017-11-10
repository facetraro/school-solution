using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Logic;
using System.Collections.Generic;
using System.Linq;
using Exceptions;
using System.Diagnostics.CodeAnalysis;

namespace Testing.LogicTest
{
    [TestClass]
    [ExcludeFromCodeCoverage]

    public class SubjectLogicTest : SetUpLogic
    {
        public void ClearRepository()
        {
            SetUp();
        }
        private Subject testSubject()
        {
            Subject aSubject = new Subject();
            aSubject.Name = "testSubject";
            aSubject.Code = "132";
            aSubject.Students = new List<Student>();
            aSubject.Teachers = new List<Teacher>();
            return aSubject;
        }
        [TestMethod]
        public void AddSubjectSuccess()
        {
            ClearRepository();
            Subject newSubjectTest = testSubject();
            SubjectLogic testLogic = new SubjectLogic();
            testLogic.Add(newSubjectTest);
            Assert.IsTrue(testLogic.Exists(newSubjectTest));
        }
        [TestMethod]
        [ExpectedException(typeof(EmptyOrNullValueException))]
        public void AddSubjectFail()
        {
            ClearRepository();
            Subject newSubject = testSubject();
            SubjectLogic testLogic = new SubjectLogic();
            testLogic.Add(newSubject);
            Subject anotherSubject = new Subject();
            testLogic.Add(anotherSubject);
            int expectedLength = 1;
            Assert.IsTrue(testLogic.Length() == expectedLength);
        }
        [TestMethod]
        [ExpectedException(typeof(EmptyOrNullValueException))]
        public void AddSubjectFailLength()
        {
            ClearRepository();
            Subject newSubject = new Subject();
            string testCode = "12";
            string anotherTestCode = "12";
            SubjectLogic testLogic = new SubjectLogic();
            newSubject.Code = testCode;
            testLogic.Add(newSubject);
            Subject anotherSubject = new Subject();
            anotherSubject.Code = anotherTestCode;
            testLogic.Add(anotherSubject);
            Assert.IsTrue(testLogic.Length() == 2);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidObjectAddIntoSubjectsException))]
        public void AddSubjectDifferentObjectFail()
        {
            ClearRepository();
            SubjectLogic testLogic = new SubjectLogic();
            int test = 0;
            testLogic.Add(test);
            int expectedSubjectLength = 0;
            Assert.IsTrue(testLogic.Length() == expectedSubjectLength);
        }
        [TestMethod]
        public void DeleteSubjectSuccess()
        {
            ClearRepository();
            Subject newSubject = testSubject();
            SubjectLogic testLogic = new SubjectLogic();
            testLogic.Add(newSubject);
            testLogic.Remove(newSubject);
            Assert.IsFalse(testLogic.Exists(newSubject));
        }
        [TestMethod]
        [ExpectedException(typeof(SubjectPersistanceException))]
        public void DeleteSubjectFail()
        {
            ClearRepository();
            Subject newSubject = testSubject();
            string testCode = "5";
            newSubject.Code = testCode;
            Subject anotherNewSubject = testSubject();
            string anotherTestCode = "6";
            anotherNewSubject.Code = anotherTestCode;
            SubjectLogic testLogic = new SubjectLogic();
            testLogic.Add(newSubject);
            testLogic.Remove(anotherNewSubject);
            Assert.IsTrue(testLogic.Exists(newSubject));
        }
        [TestMethod]
        public void ModifySubjectName()
        {
            ClearRepository();
            Subject newSubject = testSubject();
            Subject editedSubject = testSubject();
            SubjectLogic testLogic = new SubjectLogic();
            string testName = "5";
            editedSubject.Name = testName;
            testLogic.Add(newSubject);
            testLogic.Modify(newSubject, editedSubject);

            Assert.IsFalse(testLogic.GetAllSubjects().ElementAt(0).Name == newSubject.Name);
        }
        [TestMethod]
        public void ModifySubjectSuccess()
        {
            ClearRepository();
            Subject newSubject = testSubject();
            Subject editedSubject = testSubject();
            SubjectLogic testLogic = new SubjectLogic();
            string testName = "3";
            editedSubject.Name = testName;
            testLogic.Add(newSubject);
            testLogic.Modify(newSubject, editedSubject);
            Assert.IsTrue(testLogic.Exists(editedSubject));
        }
        [TestMethod]
        public void ModifyNonExistentSubject()
        {
            ClearRepository();
            Subject newSubject = testSubject();
            Subject editedSubject = new Subject();
            SubjectLogic testLogic = new SubjectLogic();
            string testCode = "3";
            editedSubject.Code = testCode;
            testLogic.Modify(newSubject, editedSubject);
            Assert.IsFalse(testLogic.Exists(editedSubject));
        }
        [TestMethod]
        [ExpectedException(typeof(EmptyOrNullValueException))]
        public void ModifySubjectFailOldSubject()
        {
            ClearRepository();
            SubjectLogic testLogic = new SubjectLogic();
            Subject newSubject = testSubject();
            Subject anotherSubject = new Subject();
            string emptyCode = "";
            anotherSubject.Code = emptyCode;
            testLogic.Add(newSubject);
            testLogic.Modify(newSubject, anotherSubject);
            testLogic.Exists(newSubject);
        }
        [TestMethod]
        public void GenerateNewCodeSuccess()
        {
            ClearRepository();
            string testCode = "testCode";
            SubjectLogic logic = new SubjectLogic();
            logic.AddNewSubject("testName");
            List<Subject> allSubjects = logic.GetAllSubjects();
            bool assertion = true;
            if (!logic.IsEmpty())
            {
                Subject subjectTest = allSubjects.ElementAt(0);
                assertion = subjectTest.Code.Equals(testCode);
            }
            Assert.IsFalse(assertion);
        }
        [TestMethod]
        public void CanIModifySubject()
        {
            ClearRepository();
            Subject oldSubject = testSubject();
            Subject newSubject = testSubject();
            newSubject.Name = "aa";
            SubjectLogic logic = new SubjectLogic();
            logic.Add(oldSubject);
            logic.Modify(oldSubject, newSubject);
            List<Subject> allSubjects = logic.GetAllSubjects();
            bool assertion = false;
            if (!logic.IsEmpty())
            {
                Subject subjectTest = allSubjects.ElementAt(0);
                assertion = subjectTest.Name.Equals("aa");
            }
            Assert.IsTrue(assertion);
        }
    }
}
