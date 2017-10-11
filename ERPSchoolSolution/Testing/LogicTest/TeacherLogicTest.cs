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
        public void ClearRepository()
        {
            TeacherLogic testLogic = new TeacherLogic();
            testLogic.Empty();
        }
        public void SetUp()
        {
            ClearRepository();
        }
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
            SetUp();
            TeacherLogic testLogic = new TeacherLogic();
            Teacher newTeacher = TeacherTest();
            testLogic.Add(newTeacher);
            Assert.IsTrue(testLogic.Exists(newTeacher));
        }
        [TestMethod]
        public void AddTeacherFail()
        {
            SetUp();
            TeacherLogic testLogic = new TeacherLogic();
            Teacher newTeacher = TeacherTest();
            testLogic.Add(newTeacher);
            testLogic.Add(newTeacher);
            int expectedTeacherListLength = 1;
            Assert.IsTrue(testLogic.Length() == expectedTeacherListLength);
        }
        [TestMethod]
        public void AddTeacherLengthSuccess()
        {
            SetUp();
            TeacherLogic testLogic = new TeacherLogic();
            Teacher newTeacher = TeacherTest();
            Teacher anotherTeacher = TeacherTest();
            anotherTeacher.Id = 2;
            testLogic.Add(newTeacher);
            testLogic.Add(newTeacher); ;
            testLogic.Add(anotherTeacher);
            int expectedTeacherListLength = 2;
            Assert.IsTrue(testLogic.Length() == expectedTeacherListLength);
        }
        [TestMethod]
        public void AddDifferentObjectTeacherFail()
        {
            SetUp();
            TeacherLogic testLogic = new TeacherLogic();
            Teacher newTeacher = TeacherTest();
            int intTest = 0;
            testLogic.Add(newTeacher);
            testLogic.Add(intTest);
            int expectedTeacherListLength = 1;
            Assert.IsTrue(testLogic.Length() == expectedTeacherListLength);
        }
        [TestMethod]
        public void AddInvalidTeacherSuccess()
        {
            SetUp();
            TeacherLogic testLogic = new TeacherLogic();
            Teacher newTeacher = new Teacher();
            testLogic.Add(newTeacher);
            int expectedTeacherListLength = 0;
            Assert.IsTrue(testLogic.Length() == expectedTeacherListLength);
        }
        [TestMethod]
        public void DeleteTeacherSuccess()
        {
            SetUp();
            TeacherLogic testLogic = new TeacherLogic();
            Teacher newTeacher = new Teacher();
            newTeacher.Name = "toDelete";
            testLogic.Add(newTeacher);
            testLogic.Remove(newTeacher);
            Assert.IsFalse(testLogic.Exists(newTeacher));
        }
        [TestMethod]
        public void ModifyTeacherSuccess()
        {
            SetUp();
            TeacherLogic testLogic = new TeacherLogic();
            Teacher newTeacher = TeacherTest();
            Teacher anotherTeacher = TeacherTest();
            anotherTeacher.Id = 99;
            testLogic.Add(newTeacher);
            testLogic.Modify(newTeacher, anotherTeacher);
            Assert.IsFalse(testLogic.Exists(newTeacher));
        }
    }
}
