using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Logic;

namespace Testing.LogicTest
{
    [TestClass]
    public class StudentLogicTest
    {
        [TestMethod]
        public void AddStudentSuccess()
        {
            Student newStudent = new Student();
            StudentLogic testLogic = new StudentLogic();
            testLogic.Add(newStudent);
            Assert.IsTrue(testLogic.Exists(newStudent));
        }
        [TestMethod]
        public void AddStudentFail()
        {
            Student newStudent = new Student();
            StudentLogic testLogic = new StudentLogic();
            testLogic.Add(newStudent);
            testLogic.Add(newStudent);
            int expectedStudentListLength = 1;
            Assert.IsTrue(testLogic.Length() == expectedStudentListLength);
        }
        [TestMethod]
        public void AddStudentLengthSuccess()
        {
            Student newStudent = new Student();
            Student anotherStudent = new Student();
            StudentLogic testLogic = new StudentLogic();
            testLogic.Add(newStudent);
            testLogic.Add(newStudent);
            testLogic.Add(anotherStudent);
            int expectedStudentListLength = 2;
            Assert.IsTrue(testLogic.Length() == expectedStudentListLength);
        }
    }
}
