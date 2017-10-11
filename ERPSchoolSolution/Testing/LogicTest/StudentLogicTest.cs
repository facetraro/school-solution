using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Logic;

namespace Testing.LogicTest
{
    [TestClass]
    public class StudentLogicTest
    {
        private Student TestStudent()
        {
            Student testStudent = new Student();
            testStudent.Id = 54;
            testStudent.Ci = 47642349;
            testStudent.Name = "TestName";
            testStudent.LastName = "TestLastName";
            return testStudent;
        }
        public void ClearRepository()
        {
            StudentLogic testLogic = new StudentLogic();
            testLogic.Empty();
        }
        public void SetUp()
        {
            ClearRepository();
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
        public void AddStudentLengthSuccess()
        {
            SetUp();
            StudentLogic testLogic = new StudentLogic();
            Student newStudent = TestStudent();
            Student anotherStudent = TestStudent();
            anotherStudent.Id = 2;
            testLogic.Add(newStudent);
            testLogic.Add(newStudent); ;
            testLogic.Add(anotherStudent);
            int expectedStudentListLength = 2;
            Assert.IsTrue(testLogic.Length() == expectedStudentListLength);
        }
        [TestMethod]
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
            anotherStudent.Id = 3;
            testLogic.Add(newStudent);
            testLogic.Modify(newStudent, anotherStudent);
            Assert.IsFalse(testLogic.Exists(newStudent));
        }
        [TestMethod]
        public void ModifyStudentCheckUpdateSuccess()
        {
            SetUp();
            StudentLogic testLogic = new StudentLogic();
            Student newStudent = TestStudent();
            Student anotherStudent = TestStudent();
            anotherStudent.Id = 3;
            testLogic.Add(newStudent);
            testLogic.Modify(newStudent, anotherStudent);
            Assert.IsTrue(testLogic.Exists(anotherStudent));
        }
        [TestMethod]
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
    }
}
