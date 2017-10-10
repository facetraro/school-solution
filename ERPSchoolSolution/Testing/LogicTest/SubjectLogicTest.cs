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
            
            Subject newSubjectTest = new Subject();
            SubjectLogic testLogic = new SubjectLogic();
            testLogic.Add(newSubjectTest);
            Assert.IsTrue(testLogic.Exists(newSubjectTest));
        }
        [TestMethod]
        public void AddSubjectFail()
        {
            Subject newSubject = new Subject();
            SubjectLogic testLogic = new SubjectLogic();
            testLogic.Add(newSubject);
            Subject anotherSubject = new Subject();
            testLogic.Add(anotherSubject);
            int expectedLength = 1;
            Assert.IsTrue(testLogic.Length() == expectedLength);
        }
    }
}
