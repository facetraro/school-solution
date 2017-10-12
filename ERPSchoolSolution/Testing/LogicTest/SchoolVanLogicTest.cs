using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Logic;
using Exceptions;
using System.Collections.Generic;

namespace Testing.LogicTest
{
    [TestClass]
    public class SchoolVanLogicTest
    {
        public void ClearRepository()
        {
            SchoolVanLogic testLogic = new SchoolVanLogic();
            testLogic.Empty();
        }
        public void SetUp()
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
    }
}
