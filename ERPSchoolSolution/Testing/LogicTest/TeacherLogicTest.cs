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
        Teacher TeacherTest()
        {
            Teacher teacherTest = new Teacher();
            teacherTest.Name = "testName";
            teacherTest.LastName = "testLastName";
            teacherTest.Id = 4;
            return teacherTest;
        }
        [TestMethod]
        public void AddTeacherSuccess()
        {
            TeacherLogic testLogic = new TeacherLogic();
            Teacher newTeacher = TeacherTest();
            testLogic.Add(newTeacher);
            Assert.IsTrue(testLogic.Exists(newTeacher));
        }
        [TestMethod]
        public void AddTeacherFail()
        {
            TeacherLogic testLogic = new TeacherLogic();
            Teacher newTeacher = TeacherTest();
            testLogic.Add(newTeacher);
            testLogic.Add(newTeacher);
            Assert.IsTrue(testLogic.Length() == 1);
        }
    }
}
