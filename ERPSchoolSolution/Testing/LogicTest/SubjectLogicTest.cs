using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Logic;
using System.Collections.Generic;

namespace Testing.LogicTest
{
    [TestClass]
    public class SubjectLogicTest
    {
        public void ClearRepository()
        {
            SubjectLogic testLogic = new SubjectLogic();
            testLogic.Empty();
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
            Subject newSubjectTest = new Subject();
            SubjectLogic testLogic = new SubjectLogic();
            testLogic.Add(newSubjectTest);
            Assert.IsTrue(testLogic.Exists(newSubjectTest));
        }
        [TestMethod]
        public void AddSubjectFail()
        {
            ClearRepository();
            Subject newSubject = new Subject();
            SubjectLogic testLogic = new SubjectLogic();
            testLogic.Add(newSubject);
            Subject anotherSubject = new Subject();
            testLogic.Add(anotherSubject);
            int expectedLength = 1;
            Assert.IsTrue(testLogic.Length() == expectedLength);
        }
        [TestMethod]

        public void AddSubjectFailLength()
        {
            ClearRepository();
            Subject newSubject = new Subject();
            string testCode = "1";
            string anotherTestCode = "12";
            SubjectLogic testLogic = new SubjectLogic();
            newSubject.Code = testCode;
            testLogic.Add(newSubject);
            Subject anotherSubject = new Subject();
            anotherSubject.Code = anotherTestCode;
            testLogic.Add(anotherSubject);
            Assert.IsTrue(testLogic.Length() == 2);
        }
    }
}
