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
            StudentLogic testLogic = new StudentLogic();
            testLogic.Empty();
            Student newStudent = new Student();
            newStudent.Id = 1;
            newStudent.Ci = 47642349;
            newStudent.Name = "TestName";
            newStudent.LastName = "TestLastName";

            testLogic.Add(newStudent);
            Assert.IsTrue(testLogic.Exists(newStudent));
        }
        [TestMethod]
        public void AddStudentFail()
        {
            StudentLogic testLogic = new StudentLogic();
            testLogic.Empty();
            Student newStudent = new Student();
            newStudent.Id = 1;
            newStudent.Ci = 47642349;
            newStudent.Name = "TestName";
            newStudent.LastName = "TestLastName";
      
            testLogic.Add(newStudent);
            testLogic.Add(newStudent);
            int expectedStudentListLength = 1;
            Assert.IsTrue(testLogic.Length() == expectedStudentListLength);
        }
        [TestMethod]
        public void AddStudentLengthSuccess()
        {
            StudentLogic testLogic = new StudentLogic();
            testLogic.Empty();
            Student newStudent = new Student();
            newStudent.Id = 1;
            newStudent.Ci = 47642349;
            newStudent.Name = "TestName";
            newStudent.LastName = "TestLastName";
            Student anotherStudent = new Student();
            anotherStudent.Id = 2;
            anotherStudent.Ci = 47642340;
            anotherStudent.Name = "TestName";
            anotherStudent.LastName = "TestLastName";
           
            testLogic.Add(newStudent);
            testLogic.Length();
            testLogic.Add(newStudent);
            testLogic.Length();
            testLogic.Add(anotherStudent);
            testLogic.Length();
            int expectedStudentListLength = 2;
            Assert.IsTrue(testLogic.Length() == expectedStudentListLength);
        }
        [TestMethod]
        public void AddDifferentObjectStudentFail()
        {
            StudentLogic testLogic = new StudentLogic();
            testLogic.Empty();
            Student newStudent = new Student();
            newStudent.Id = 1;
            newStudent.Ci = 47642349;
            newStudent.Name = "TestName";
            newStudent.LastName = "TestLastName";
            int a = 0;
            testLogic.Add(newStudent);
            testLogic.Add(a);
            int expectedStudentListLength = 1;
            Assert.IsTrue(testLogic.Length() == expectedStudentListLength);
        }
    }
}
