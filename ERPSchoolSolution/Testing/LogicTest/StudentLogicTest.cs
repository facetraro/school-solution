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
    }
}
