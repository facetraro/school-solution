using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Logic;
using System.Linq;

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
        [TestMethod]
        public void ModifyTeacherCheckUpdateSuccess()
        {
            SetUp();
            TeacherLogic testLogic = new TeacherLogic();
            Teacher newTeacher = TeacherTest();
            Teacher anotherTeacher = TeacherTest();
            int differentId = 99;
            anotherTeacher.Id = differentId;
            testLogic.Add(newTeacher);
            testLogic.Modify(newTeacher, anotherTeacher);
            Assert.IsTrue(testLogic.Exists(anotherTeacher));
        }
        [TestMethod]
        public void ModifyTeacherFail()
        {
            SetUp();
            TeacherLogic testLogic = new TeacherLogic();
            Teacher newTeacher = TeacherTest();
            Teacher anotherTeacher = TeacherTest();
            anotherTeacher.Id = -3;
            anotherTeacher.Name = "";
            testLogic.Add(newTeacher);
            testLogic.Modify(newTeacher, anotherTeacher);
            Assert.IsFalse(testLogic.Exists(anotherTeacher));
        }
        [TestMethod]
        public void ModifyTeacherModifyNonExistent()
        {
            SetUp();
            TeacherLogic testLogic = new TeacherLogic();
            Teacher newTeacher = TeacherTest();
            Teacher anotherTeacher = TeacherTest();
            anotherTeacher.Id = 4;
            testLogic.Modify(newTeacher, anotherTeacher);
            Assert.IsFalse(testLogic.Exists(anotherTeacher));
        }
        [TestMethod]
        public void ModifyTeacherFailCheckOldTeacher()
        {
            SetUp();
            TeacherLogic testLogic = new TeacherLogic();
            Teacher newTeacher = TeacherTest();
            Teacher anotherTeacher = TeacherTest();
            anotherTeacher.Id = -3;
            anotherTeacher.Name = "";
            testLogic.Add(newTeacher);
            testLogic.Modify(newTeacher, anotherTeacher);
            Assert.IsTrue(testLogic.Exists(newTeacher));
        }
        [TestMethod]
        public void ModifyTeacherWithTheSameId()
        {
            SetUp();
            TeacherLogic testLogic = new TeacherLogic();
            Teacher teacher = TeacherTest();
            Teacher updateTeacher = TeacherTest();
            updateTeacher.Name = "new Name";
            testLogic.Add(teacher);
            testLogic.Modify(teacher, updateTeacher);
            List<Teacher> list = testLogic.GetAllTeachers();
            bool assertion = false;
            if (list.Count != 0)
            {
                Teacher testTeacher = list.ElementAt(0);
                assertion = testTeacher.Name.Equals("new Name");
            }
            Assert.IsTrue(assertion);
        }
        [TestMethod]
        public void GetFirstNextStudentId()
        {
            SetUp();
            TeacherLogic logic = new TeacherLogic();
            int expectedValue = 1;
            Assert.IsTrue(logic.GetNextIdFree().Equals(expectedValue));

        }
    }
}
