using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Logic;

namespace Testing.LogicTest
{
    [TestClass]
    public class TeacherLogicTest
    {
        [TestMethod]
        public void AddTeacherSuccess()
        {
            TeacherLogic testLogic = new TeacherLogic();
            Teacher newTeacher = new Teacher();
            testLogic.Add(newTeacher);
            Assert.IsTrue(testLogic.Exists(newTeacher));
        }
    }
}
