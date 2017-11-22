using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERPSchoolValidator;
using Logic;
using System.Collections.Generic;
using System.Linq;
using Exceptions;
using System.Diagnostics.CodeAnalysis;

namespace Testing.LogicTest
{
    [TestClass]
    [ExcludeFromCodeCoverage]

    public class StudentLogicTest : SetUpLogic
    {
        private Student TestStudent()
        {
            Subject newSubject = new Subject();
            newSubject.Code = "aaa";
            newSubject.Name = "test"; ;
            Student testStudent = new Student();
            testStudent.Subjects.Add(newSubject);
            testStudent.Ci = 47803333;
            testStudent.Id = 123;
            testStudent.StudentNumber = 123;
            testStudent.Name = "TestName";
            testStudent.LastName = "TestLastName";
            return testStudent;
        }
        [TestMethod]
        public void AddStudentSuccess()
        {
            SetUp();
            StudentLogic testLogic = new StudentLogic();
            Student newStudent = TestStudent();
            testLogic.Add(newStudent);
            Assert.IsTrue(testLogic.Exists(newStudent));
        }
        [TestMethod]
        [ExpectedException(typeof(Exceptions.InvalidCiException))]
        public void AddStudentFail()
        {
            SetUp();
            StudentLogic testLogic = new StudentLogic();
            Student newStudent = TestStudent();
            testLogic.Add(newStudent);
            testLogic.Add(newStudent);
            int expectedStudentListLength = 1;
            Assert.IsTrue(testLogic.Length() == expectedStudentListLength);
        }
        [TestMethod]
        [ExpectedException(typeof(Exceptions.InvalidCiException))]
        public void AddStudentLengthSuccess()
        {
            SetUp();
            StudentLogic testLogic = new StudentLogic();
            Student newStudent = TestStudent();
            Student anotherStudent = TestStudent();
            anotherStudent.Id = 2;
            anotherStudent.Ci = newStudent.Ci+2;
            testLogic.Add(newStudent);
            testLogic.Add(newStudent); ;
            testLogic.Add(anotherStudent);
            int expectedStudentListLength = 2;
            Assert.IsTrue(testLogic.Length() == expectedStudentListLength);
        }
        [TestMethod]
        [ExpectedException(typeof(Exceptions.InvalidObjectAddIntoStudentException))]
        public void AddDifferentObjectStudentFail()
        {
            SetUp();
            StudentLogic testLogic = new StudentLogic();
            Student newStudent = TestStudent();
            int intTest = 0;
            testLogic.Add(newStudent);
            testLogic.Add(intTest);
            int expectedStudentListLength = 1;
            Assert.IsTrue(testLogic.Length() == expectedStudentListLength);
        }
        [TestMethod]
        public void DeleteStudentSuccess()
        {
            SetUp();
            StudentLogic testLogic = new StudentLogic();
            Student newStudent = TestStudent();
            testLogic.Add(newStudent);
            testLogic.Remove(newStudent);
            Assert.IsFalse(testLogic.Exists(newStudent));
        }
        [TestMethod]
        public void ModifyStudentSuccess()
        {
            SetUp();
            StudentLogic testLogic = new StudentLogic();
            Student newStudent = TestStudent();
            Student anotherStudent = TestStudent();
            anotherStudent.LastName = "newLastName";
            testLogic.Add(newStudent);
            anotherStudent.Id=testLogic.GetNextIdFree()-1;
            testLogic.Modify(newStudent, anotherStudent);
            List<Student> list = testLogic.GetAllStudents();
            bool validation = false;
            if (list.Count != 0)
            {
                validation = (list.ElementAt(0).LastName == anotherStudent.LastName);
            }
            Assert.IsTrue(validation);
        }
        [TestMethod]
        [ExpectedException(typeof(EmptyOrNullValueException))]
        public void ModifyStudentFail()
        {
            SetUp();
            StudentLogic testLogic = new StudentLogic();
            Student newStudent = TestStudent();
            Student anotherStudent = TestStudent();
            anotherStudent.Id = -3;
            anotherStudent.Name = "";
            testLogic.Add(newStudent);
            testLogic.Modify(newStudent, anotherStudent);
            Assert.IsFalse(testLogic.Exists(anotherStudent));
        }
        [TestMethod]
        public void ModifyStudentModifyNonExistent()
        {
            SetUp();
            StudentLogic testLogic = new StudentLogic();
            Student newStudent = TestStudent();
            Student anotherStudent = TestStudent();
            anotherStudent.Id = 4;
            testLogic.Modify(newStudent, anotherStudent);
            Assert.IsFalse(testLogic.Exists(anotherStudent));
        }
        [TestMethod]
        [ExpectedException(typeof(EmptyOrNullValueException))]
        public void ModifyStudentFailCheckOldStudent()
        {
            SetUp();
            StudentLogic testLogic = new StudentLogic();
            Student newStudent = TestStudent();
            Student anotherStudent = TestStudent();
            anotherStudent.Id = -3;
            anotherStudent.Name = "";
            testLogic.Add(newStudent);
            testLogic.Modify(newStudent, anotherStudent);
            Assert.IsTrue(testLogic.Exists(newStudent));
        }
        [TestMethod]
        [ExpectedException(typeof(StudentAlreadyExistsException))]
        public void ModifyStudentWithTheSameId()
        {
            SetUp();
            StudentLogic testLogic = new StudentLogic();
            Student newStudent = TestStudent();
            Student anotherStudent = TestStudent();
            anotherStudent.Name = "new Name";
            anotherStudent.Ci = 46546549;
            testLogic.Add(newStudent);
            testLogic.Add(anotherStudent);
            testLogic.Modify(newStudent, anotherStudent);
            List<Student> list = testLogic.GetAllStudents();
            bool assertion = false;
            if (list.Count != 0)
            {
                Student testStudent = list.ElementAt(0);
                assertion = testStudent.Name.Equals("new Name");
            }
            Assert.IsTrue(assertion);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidCiException))]
        public void ModifyStudentWithDiferentIdCiExsits()
        {
            SetUp();
            StudentLogic testLogic = new StudentLogic();
            Student newStudent = TestStudent();
            Student anotherStudent = TestStudent();
            anotherStudent.Name = "new Name";
            anotherStudent.Ci = 46547749;
            Student updateStudent = newStudent;
            updateStudent.Ci = 46547749;
            testLogic.Add(newStudent);
            testLogic.Add(anotherStudent);
            testLogic.Modify(newStudent, updateStudent);
        }
        [TestMethod]
        public void GetFirstNextStudentId()
        {
            SetUp();
            StudentLogic logic = new StudentLogic();
            int expectedValue = 1;
            Assert.IsTrue(logic.GetNextIdFree().Equals(expectedValue));

        }
        [TestMethod]
        public void GetNextStudentId()
        {
            SetUp();
            StudentLogic logic = new StudentLogic();
            Student newStudent = TestStudent();
            newStudent.Id = 1;
            logic.Add(newStudent);
            int expectedValue = 0;
            Assert.IsFalse(logic.GetNextIdFree().Equals(expectedValue));
        }
    }
}
