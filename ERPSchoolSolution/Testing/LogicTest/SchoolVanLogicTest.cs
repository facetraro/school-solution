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
        private void ClearRepository()
        {
            SchoolVanLogic testLogic = new SchoolVanLogic();
            testLogic.Empty();
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
            expectedRoute.Add(schoolCoordinate);
            List<Route> expectedRoutes = new List<Route>();
            expectedRoutes.Add(expectedRoute);
            List<Route> obtainRoutes = schoolVanLogic.GetBestRoutes();
            string expectedRoutesString = "";
            string obtainRoutesString = "";
            foreach (Route route in expectedRoutes)
            {
                expectedRoutesString = route.ToStringRoute();
            }
            foreach (Route route in obtainRoutes)
            {
                obtainRoutesString = route.ToStringRoute();
            }
            Assert.AreEqual(expectedRoutesString, obtainRoutesString);
        }
        [TestMethod]
        public void SchoolVanStudentAssignmentSuccess()
        {
            SetUp();
            List<Tuple<SchoolVan, List<Student>>> expectedValue = new List<Tuple<SchoolVan, List<Student>>>();

            StudentLogic testLogic = new StudentLogic();


            SchoolVanLogic schoolVanLogic = new SchoolVanLogic();
            Student newStudent = new Student();
            newStudent.Ci = 47803333;
            newStudent.Id = 1;
            newStudent.Name = "TestName";
            newStudent.LastName = "TestLastName";
            testLogic.Add(newStudent);
            Student anotherStudent = new Student();
            anotherStudent.Ci = 47803333;
            anotherStudent.Id = 7;
            anotherStudent.Name = "TestName";
            anotherStudent.LastName = "TestLastName";
            testLogic.Add(anotherStudent);
            Student otherStudent = new Student();
            otherStudent.Ci = 47803333;
            otherStudent.Id = 5;
            otherStudent.Name = "TestName";
            otherStudent.LastName = "TestLastName";
            testLogic.Add(otherStudent);
            Student lastStudent = new Student();
            lastStudent.Ci = 47803333;
            lastStudent.Id = 2;
            lastStudent.Name = "TestName";
            lastStudent.LastName = "TestLastName";
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



    }
}
