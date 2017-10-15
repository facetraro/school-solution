using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Logic;
using Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace Testing.LogicTest
{
    [TestClass]
    public class SchoolVanLogicTest
    {
        private bool CompareStudentAssignment(List<Tuple<SchoolVan, List<Student>>> a1, List<Tuple<SchoolVan, List<Student>>> a2)
        {
            int actualValue = 0;
            foreach (Tuple<SchoolVan, List<Student>> touple in a1)
            {
                Tuple<SchoolVan, List<Student>> anotherTouple = a2.ElementAt(actualValue);
                if (!touple.Item1.Equals(anotherTouple.Item1))
                {
                    return false;
                }
                if (!touple.Item2.SequenceEqual(anotherTouple.Item2))
                {
                    return false;
                }
                actualValue++;
            }
            return true;
        }
        private Student TestStudent(int id)
        {
            Student testStudent = new Student();
            testStudent.Ci = 47803333;
            testStudent.Id = id;
            testStudent.Name = "TestName";
            testStudent.LastName = "TestLastName";
            return testStudent;
        }
        private void ClearRepository()
        {
            SchoolVanLogic testLogic = new SchoolVanLogic();
            StudentLogic studentLogic = new StudentLogic();
            testLogic.Empty();
            studentLogic.Empty();
        }
        private void SetUp()
        {
            ClearRepository();
        }
        [TestMethod]
        public void AddSchoolVanSuccess()
        {
            SetUp();
            SchoolVan newSchoolVan = new SchoolVan();
            SchoolVanLogic testLogic = new SchoolVanLogic();
            testLogic.Add(newSchoolVan);
            Assert.IsTrue(testLogic.Exists(newSchoolVan));
        }
        [TestMethod]
        public void AddSchoolVanFail()
        {
            SetUp();
            SchoolVan newSchoolVan = new SchoolVan();
            SchoolVanLogic testLogic = new SchoolVanLogic();
            testLogic.Add(newSchoolVan);
            SchoolVan anotherNewSchoolVan = new SchoolVan();
            testLogic.Add(anotherNewSchoolVan);
            int expectedSchoolVanListLength = 1;
            Assert.IsTrue(testLogic.Length() == expectedSchoolVanListLength);
        }
        [TestMethod]
        public void AddSchoolVanDifferentObjectFail()
        {
            SetUp();
            SchoolVanLogic testLogic = new SchoolVanLogic();
            int test = 0;
            testLogic.Add(test);
            int expectedSchoolVanListLength = 0;
            Assert.IsTrue(testLogic.Length() == expectedSchoolVanListLength);
        }
        [TestMethod]
        public void AddInvalidSchoolVan()
        {
            SetUp();
            SchoolVan newSchoolVan = new SchoolVan();
            newSchoolVan.Capacity = -30;
            SchoolVanLogic testLogic = new SchoolVanLogic();
            testLogic.Add(newSchoolVan);
            Assert.IsFalse(testLogic.Exists(newSchoolVan));
        }
        [TestMethod]
        public void ExistsSchoolVanFail()
        {
            SetUp();
            SchoolVan newSchoolVan = new SchoolVan();
            SchoolVanLogic testLogic = new SchoolVanLogic();
            Assert.IsFalse(testLogic.Exists(newSchoolVan));
        }
        [TestMethod]
        public void DeleteSchoolDifferentObjectFail()
        {
            SetUp();
            SchoolVan newSchoolVan = new SchoolVan();
            SchoolVanLogic testLogic = new SchoolVanLogic();
            int testInt = 0;
            testLogic.Add(newSchoolVan);
            testLogic.Remove(testInt);
            Assert.IsTrue(testLogic.Exists(newSchoolVan));
        }
        [TestMethod]
        public void DeleteSchoolVanSuccess()
        {
            SetUp();
            SchoolVan newSchoolVan = new SchoolVan();
            SchoolVanLogic testLogic = new SchoolVanLogic();
            testLogic.Add(newSchoolVan);
            testLogic.Remove(newSchoolVan);
            Assert.IsFalse(testLogic.Exists(newSchoolVan));
        }
        [TestMethod]
        public void DeleteSchoolVanFail()
        {
            SetUp();
            SchoolVan newSchoolVan = new SchoolVan();
            newSchoolVan.Id = 5;
            SchoolVan anotherSchoolVan = new SchoolVan();
            anotherSchoolVan.Id = 6;
            SchoolVanLogic testLogic = new SchoolVanLogic();
            testLogic.Add(newSchoolVan);
            testLogic.Remove(anotherSchoolVan);
            Assert.IsTrue(testLogic.Exists(newSchoolVan));
        }
        [TestMethod]
        public void ModifySchoolVanFail()
        {
            SetUp();
            SchoolVan schoolVan = new SchoolVan();
            SchoolVanLogic testLogic = new SchoolVanLogic();
            SchoolVan editedSchoolVan = new SchoolVan();
            editedSchoolVan.Id = 50;
            testLogic.Add(schoolVan);
            testLogic.Modify(schoolVan, editedSchoolVan);
            Assert.IsFalse(testLogic.Exists(schoolVan));
        }
        [TestMethod]
        public void ModifySchoolVanSuccess()
        {
            SetUp();
            SchoolVan schoolVan = new SchoolVan();
            schoolVan.Id = 4;
            SchoolVanLogic testLogic = new SchoolVanLogic();
            SchoolVan editedSchoolVan = new SchoolVan();
            editedSchoolVan.Id = 50;
            testLogic.Add(schoolVan);
            testLogic.Modify(schoolVan, editedSchoolVan);
            Assert.IsTrue(testLogic.Exists(editedSchoolVan));

        }
        [TestMethod]
        public void ModifySchoolVanModifyNonExistent()
        {
            SetUp();
            SchoolVan schoolVan = new SchoolVan();
            schoolVan.Id = 4;
            SchoolVanLogic testLogic = new SchoolVanLogic();
            SchoolVan editedSchoolVan = new SchoolVan();
            editedSchoolVan.Id = 50;
            testLogic.Modify(schoolVan, editedSchoolVan);
            Assert.IsFalse(testLogic.Exists(editedSchoolVan));
        }
        [TestMethod]
        public void ModifySchoolVanFailCheckOldSchoolVan()
        {
            SetUp();
            SchoolVanLogic testLogic = new SchoolVanLogic();
            SchoolVan newSchoolVan = new SchoolVan();
            SchoolVan anotherSchoolVan = new SchoolVan();
            anotherSchoolVan.Id = -3;
            testLogic.Add(newSchoolVan);
            testLogic.Modify(newSchoolVan, anotherSchoolVan);
            Assert.IsTrue(testLogic.Exists(newSchoolVan));
        }
        [TestMethod]
        [ExpectedException(typeof(NoStudentsInSystemException))]
        public void GetBestRoutesWithoutStudents()
        {
            SetUp();
            NoStudentsInSystemException expectedExcetpion = new NoStudentsInSystemException("No Students in the system");
            SchoolVanLogic testLogic = new SchoolVanLogic();
            SchoolVan newSchoolVan = new SchoolVan();
            testLogic.Add(newSchoolVan);
            testLogic.GetBestRoutes();
        }
        [TestMethod]
        [ExpectedException(typeof(NoSchoolVanInSystemException))]
        public void GetBestRoutesWithoutSchoolVan()
        {
            SetUp();
            NoStudentsInSystemException expectedExcetpion = new NoStudentsInSystemException("No Students in the system");
            StudentLogic testLogic = new StudentLogic();
            SchoolVanLogic schoolVanLogic = new SchoolVanLogic();
            Student newStudent = new Student();
            newStudent.Ci = 47803333;
            newStudent.Id = 1;
            newStudent.Name = "TestName";
            newStudent.LastName = "TestLastName";
            testLogic.Add(newStudent);
            schoolVanLogic.GetBestRoutes();
        }
        [TestMethod]
        public void GetBasicBestRoutes()
        {
            SetUp();
            StudentLogic testLogic = new StudentLogic();
            SchoolVanLogic schoolVanLogic = new SchoolVanLogic();
            Student newStudent = new Student();
            newStudent.Ci = 47803333;
            newStudent.Id = 1;
            newStudent.Name = "TestName";
            newStudent.LastName = "TestLastName";
            testLogic.Add(newStudent);
            SchoolVanLogic logic = new SchoolVanLogic();
            SchoolVan newSchoolVan = new SchoolVan();
            logic.Add(newSchoolVan);
            Route expectedRoute = new Route();
            Coordinate schoolCoordinate = new Coordinate();
            expectedRoute.Add(schoolCoordinate);
            expectedRoute.Add(newStudent);
            List<Route> expectedRoutes = new List<Route>();
            expectedRoutes.Add(expectedRoute);
            List<Route> obtainRoutes = schoolVanLogic.GetBestRoutes();
            Assert.IsTrue(obtainRoutes.SequenceEqual(expectedRoutes));
        }
        [TestMethod]
        public void SchoolVanStudentAssignmentSuccess()
        {
            SetUp();
            List<Tuple<SchoolVan, List<Student>>> expectedValue = new List<Tuple<SchoolVan, List<Student>>>();
            StudentLogic testLogic = new StudentLogic();
            SchoolVanLogic schoolVanLogic = new SchoolVanLogic();
            Student newStudent = TestStudent(1);
            testLogic.Add(newStudent);
            Student anotherStudent = TestStudent(6);
            testLogic.Add(anotherStudent);
            Student otherStudent = TestStudent(5);
            testLogic.Add(otherStudent);
            Student lastStudent = TestStudent(2);
            testLogic.Add(lastStudent);
            SchoolVanLogic logic = new SchoolVanLogic();
            SchoolVan newSchoolVan = new SchoolVan();
            newSchoolVan.Id = 15;
            newSchoolVan.Capacity = 10;
            logic.Add(newSchoolVan);
            List<Student> firstStudentList = new List<Student>();
            firstStudentList.Add(newStudent);
            firstStudentList.Add(lastStudent);
            SchoolVan anotherSchoolVan = new SchoolVan();
            anotherSchoolVan.Id = 25;
            anotherSchoolVan.Capacity = 14;
            logic.Add(anotherSchoolVan);
            List<Student> nextStudentList = new List<Student>();
            nextStudentList.Add(otherStudent);
            nextStudentList.Add(anotherStudent);
            Tuple<SchoolVan, List<Student>> firstTouple = new Tuple<SchoolVan, List<Student>>(anotherSchoolVan, firstStudentList);
            Tuple<SchoolVan, List<Student>> nextTouple = new Tuple<SchoolVan, List<Student>>(newSchoolVan, nextStudentList);
            expectedValue.Add(firstTouple);
            expectedValue.Add(nextTouple);
            List<Tuple<SchoolVan, List<Student>>> ObtainValue = logic.StudentAssignment();
            Assert.IsTrue(CompareStudentAssignment(ObtainValue, expectedValue));
        }
        [TestMethod]
        public void SchoolVanStudentAssignmentDecimal()
        {
            SetUp();
            List<Tuple<SchoolVan, List<Student>>> expectedValue = new List<Tuple<SchoolVan, List<Student>>>();
            StudentLogic testLogic = new StudentLogic();
            SchoolVanLogic schoolVanLogic = new SchoolVanLogic();
            Student newStudent = TestStudent(1);
            testLogic.Add(newStudent);
            Student otherStudent = TestStudent(5);
            testLogic.Add(otherStudent);
            Student lastStudent = TestStudent(2);
            testLogic.Add(lastStudent);
            SchoolVanLogic logic = new SchoolVanLogic();
            SchoolVan newSchoolVan = new SchoolVan();
            newSchoolVan.Id = 15;
            newSchoolVan.Capacity = 10;
            logic.Add(newSchoolVan);
            List<Student> firstStudentList = new List<Student>();
            firstStudentList.Add(newStudent);
            firstStudentList.Add(lastStudent);
            SchoolVan anotherSchoolVan = new SchoolVan();
            anotherSchoolVan.Id = 25;
            anotherSchoolVan.Capacity = 14;
            logic.Add(anotherSchoolVan);
            List<Student> nextStudentList = new List<Student>();
            nextStudentList.Add(otherStudent);
            Tuple<SchoolVan, List<Student>> firstTouple = new Tuple<SchoolVan, List<Student>>(anotherSchoolVan, firstStudentList);
            Tuple<SchoolVan, List<Student>> nextTouple = new Tuple<SchoolVan, List<Student>>(newSchoolVan, nextStudentList);
            expectedValue.Add(firstTouple);
            expectedValue.Add(nextTouple);
            List<Tuple<SchoolVan, List<Student>>> ObtainValue = logic.StudentAssignment();
            Assert.IsTrue(CompareStudentAssignment(ObtainValue, expectedValue));
        }
        [TestMethod]
        public void GetAdvancedBestRoutes()
        {
            SetUp();
            StudentLogic testLogic = new StudentLogic();
            SchoolVanLogic schoolVanLogic = new SchoolVanLogic();
            Student student1 = TestStudent(1);
            student1.Coordinates.X = 8;
            student1.Coordinates.Y = 8;
            testLogic.Add(student1);
            Student student2 = TestStudent(6);
            student2.Coordinates.X = 9;
            student2.Coordinates.Y = 9;
            testLogic.Add(student2);
            Student student3 = TestStudent(3);
            student3.Coordinates.X = 1;
            student3.Coordinates.Y = 1;
            testLogic.Add(student3);
            Student student4 = TestStudent(2);
            student4.Coordinates.X = 5;
            student4.Coordinates.Y = 5;
            testLogic.Add(student4);
            Student student5 = TestStudent(8);
            student5.Coordinates.X = 5;
            student5.Coordinates.Y = 9;
            testLogic.Add(student5);
            SchoolVanLogic logic = new SchoolVanLogic();
            SchoolVan newSchoolVan = new SchoolVan();
            newSchoolVan.Capacity = 2;
            logic.Add(newSchoolVan);
            SchoolVan anotherSchoolVan = new SchoolVan();
            anotherSchoolVan.Capacity = 3;
            anotherSchoolVan.Id = 4;
            logic.Add(anotherSchoolVan);


            Route expectedRoute1 = new Route();
            expectedRoute1.TheRoute.Add(new Coordinate());
            expectedRoute1.TheRoute.Add(student3);
            expectedRoute1.TheRoute.Add(student4);
            expectedRoute1.TheRoute.Add(student1);
            expectedRoute1.TheSchoolVan = anotherSchoolVan;

            Route expectedRoute2 = new Route();
            expectedRoute2.TheRoute.Add(new Coordinate());
            expectedRoute2.TheRoute.Add(student5);
            expectedRoute2.TheRoute.Add(student2);
            expectedRoute2.TheSchoolVan = newSchoolVan;

            List<Route> expectedRoutes = new List<Route>();
            expectedRoutes.Add(expectedRoute1);
            expectedRoutes.Add(expectedRoute2);
            List<Route> obtainRoutes = schoolVanLogic.GetBestRoutes();

            Assert.IsTrue(obtainRoutes.SequenceEqual(expectedRoutes));
        }
        [TestMethod]
        public void ModifySchoolVanWithTheSameId()
        {
            SetUp();
            SchoolVanLogic testLogic = new SchoolVanLogic();
            SchoolVan schoolVan = new SchoolVan();
            schoolVan.Id = 4;
            schoolVan.Capacity = 14;
            SchoolVan updateSchoolVan = new SchoolVan();
            updateSchoolVan.Id = 4;
            updateSchoolVan.Capacity = 4;

            testLogic.Modify(schoolVan, updateSchoolVan);
            List<SchoolVan> list = testLogic.GetSchoolVansSortedByCapacity();
            bool assertion = false;
            if (list.Count != 0)
            {
                SchoolVan test = list.ElementAt(0);
                assertion = test.Capacity.Equals(4);
            }
            Assert.IsTrue(assertion);
        }
    }
}
