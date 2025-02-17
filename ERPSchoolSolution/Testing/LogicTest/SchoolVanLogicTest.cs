﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERPSchoolValidator;
using Logic;
using Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.CodeAnalysis;

namespace Testing.LogicTest
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class SchoolVanLogicTest : SetUpLogic
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
            Subject newSubject = new Subject();
            newSubject.Code = "aaa";
            newSubject.Name = "test"; ;
            Student testStudent = new Student();
            testStudent.Subjects.Add(newSubject);
            testStudent.Ci = 47803333 + id;
            testStudent.StudentNumber = id;
            testStudent.Id = id;
            testStudent.Name = "TestName";
            testStudent.LastName = "TestLastName";
            return testStudent;
        }
        [TestMethod]
        public void SchoolVanStudentAssignmentSuccess()
        {
            SetUp();
            List<Tuple<SchoolVan, List<Student>>> expectedValue = new List<Tuple<SchoolVan, List<Student>>>();
            StudentLogic testLogic = new StudentLogic();
            SchoolVanLogic schoolVanLogic = new SchoolVanLogic();
            Student newStudent = TestStudent(100);
            testLogic.Add(newStudent);
            newStudent.Id = testLogic.GetNextIdFree() - 1;

            Student lastStudent = TestStudent(200);
            testLogic.Add(lastStudent);
            lastStudent.Id = testLogic.GetNextIdFree() - 1;

            Student otherStudent = TestStudent(300);
            testLogic.Add(otherStudent);
            otherStudent.Id = testLogic.GetNextIdFree() - 1;

            Student anotherStudent = TestStudent(400);
            testLogic.Add(anotherStudent);
            anotherStudent.Id = testLogic.GetNextIdFree() - 1;

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
        public void AddSchoolVanSuccess()
        {
            SetUp();
            SchoolVan newSchoolVan = new SchoolVan();
            SchoolVanLogic testLogic = new SchoolVanLogic();
            testLogic.Add(newSchoolVan);
            Assert.IsTrue(testLogic.Exists(newSchoolVan));
        }
        [TestMethod]
        public void SchoolVanLengthSuccess()
        {
            SetUp();
            SchoolVan newSchoolVan = new SchoolVan();
            SchoolVanLogic testLogic = new SchoolVanLogic();
            testLogic.Add(newSchoolVan);
            Assert.IsTrue(testLogic.Length() == 1);
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
            int expectedSchoolVanListLength = 2;
            Assert.IsTrue(testLogic.Length() == expectedSchoolVanListLength);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidObjectAddIntoSchoolVanException))]
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
        [ExpectedException(typeof(InvalidValueException))]
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
        [ExpectedException(typeof(InvalidValueException))]
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
            newSchoolVan.Id = testLogic.GetNextIdFree() - 1;
            testLogic.Remove(newSchoolVan);
            Assert.IsFalse(testLogic.Exists(newSchoolVan));
        }
        [TestMethod]
        [ExpectedException(typeof(SchoolVanPersistanceException))]
        public void DeleteSchoolVanFail()
        {
            SetUp();
            SchoolVan newSchoolVan = new SchoolVan();
            newSchoolVan.Id = 5;
            SchoolVan anotherSchoolVan = new SchoolVan();
            anotherSchoolVan.Id = 6;
            SchoolVanLogic testLogic = new SchoolVanLogic();
            testLogic.Add(newSchoolVan);
            newSchoolVan.Id = testLogic.GetNextIdFree() - 1;
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
            testLogic.Add(schoolVan);
            schoolVan.Id = testLogic.GetNextIdFree() - 1;
            editedSchoolVan.Id = testLogic.GetNextIdFree() - 1;
            testLogic.Modify(schoolVan, editedSchoolVan);
            Assert.IsTrue(testLogic.Exists(editedSchoolVan));
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
        [ExpectedException(typeof(EmptyOrNullValueException))]
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
            testLogic.Add(schoolVan);
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
            Student newStudent = TestStudent(1);
            testLogic.Add(newStudent);
            schoolVanLogic.GetBestRoutes();
        }
        [TestMethod]
        public void GetBasicBestRoutes()
        {
            SetUp();
            StudentLogic testLogic = new StudentLogic();
            SchoolVanLogic schoolVanLogic = new SchoolVanLogic();
            Student newStudent = TestStudent(1);
            newStudent.Id = testLogic.GetNextIdFree() - 1;
            testLogic.Add(newStudent);
            SchoolVanLogic logic = new SchoolVanLogic();
            SchoolVan newSchoolVan = new SchoolVan();
            logic.Add(newSchoolVan);
            newSchoolVan.Id = logic.GetNextIdFree() - 1;
            Route expectedRoute = new Route();
            expectedRoute.TheSchoolVan = newSchoolVan;
            Coordinate schoolCoordinate = new Coordinate();
            expectedRoute.Add(schoolCoordinate);
            expectedRoute.Add(newStudent);
            List<Route> expectedRoutes = new List<Route>();

            expectedRoutes.Add(expectedRoute);
            List<Route> obtainRoutes = schoolVanLogic.GetBestRoutes();
            Assert.IsTrue(obtainRoutes.SequenceEqual(expectedRoutes));
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
            newStudent.Id = testLogic.GetNextIdFree() - 1;
            Student lastStudent = TestStudent(2);
            testLogic.Add(lastStudent);
            lastStudent.Id = testLogic.GetNextIdFree() - 1;
            Student otherStudent = TestStudent(5);
            testLogic.Add(otherStudent);
            otherStudent.Id = testLogic.GetNextIdFree() - 1;
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
            student1.Id = testLogic.GetNextIdFree() - 1;

            Student student4 = TestStudent(2);
            student4.Coordinates.X = 5;
            student4.Coordinates.Y = 5;
            testLogic.Add(student4);
            student4.Id = testLogic.GetNextIdFree() - 1;

            Student student3 = TestStudent(3);
            student3.Coordinates.X = 1;
            student3.Coordinates.Y = 1;
            testLogic.Add(student3);
            student3.Id = testLogic.GetNextIdFree() - 1;

            Student student2 = TestStudent(6);
            student2.Coordinates.X = 9;
            student2.Coordinates.Y = 9;
            testLogic.Add(student2);
            student2.Id = testLogic.GetNextIdFree() - 1;

            Student student5 = TestStudent(8);
            student5.Coordinates.X = 5;
            student5.Coordinates.Y = 9;
            testLogic.Add(student5);
            student5.Id = testLogic.GetNextIdFree() - 1;

            SchoolVanLogic logic = new SchoolVanLogic();
            SchoolVan newSchoolVan = new SchoolVan();
            newSchoolVan.Capacity = 2;
            logic.Add(newSchoolVan);
            newSchoolVan.Id = logic.GetNextIdFree() - 1;
            SchoolVan anotherSchoolVan = new SchoolVan();
            anotherSchoolVan.Capacity = 3;
            anotherSchoolVan.Id = 4;
            logic.Add(anotherSchoolVan);
            anotherSchoolVan.Id = logic.GetNextIdFree() - 1;

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
        public void GetAdvancedBestRoutesBestFuel()
        {
            SetUp();
            StudentLogic testLogic = new StudentLogic();
            SchoolVanLogic schoolVanLogic = new SchoolVanLogic();
            Student student1 = TestStudent(1);
            student1.Coordinates.X = 8;
            student1.Coordinates.Y = 8;
            testLogic.Add(student1);
            student1.Id = testLogic.GetNextIdFree() - 1;

            Student student4 = TestStudent(2);
            student4.Coordinates.X = 5;
            student4.Coordinates.Y = 5;
            testLogic.Add(student4);
            student4.Id = testLogic.GetNextIdFree() - 1;

            Student student3 = TestStudent(3);
            student3.Coordinates.X = 1;
            student3.Coordinates.Y = 1;
            testLogic.Add(student3);
            student3.Id = testLogic.GetNextIdFree() - 1;

            Student student2 = TestStudent(6);
            student2.Coordinates.X = 9;
            student2.Coordinates.Y = 9;
            testLogic.Add(student2);
            student2.Id = testLogic.GetNextIdFree() - 1;

            Student student5 = TestStudent(8);
            student5.Coordinates.X = 5;
            student5.Coordinates.Y = 9;
            testLogic.Add(student5);
            student5.Id = testLogic.GetNextIdFree() - 1;

            SchoolVanLogic logic = new SchoolVanLogic();
            SchoolVan newSchoolVan = new SchoolVan();
            newSchoolVan.Capacity = 2;
            newSchoolVan.FuelConsumption = 4;
            logic.Add(newSchoolVan);
            newSchoolVan.Id = logic.GetNextIdFree() - 1;
            SchoolVan anotherSchoolVan = new SchoolVan();
            anotherSchoolVan.Capacity = 3;
            anotherSchoolVan.Id = 76565;
            anotherSchoolVan.FuelConsumption = 10;
            logic.Add(anotherSchoolVan);
            anotherSchoolVan.Id = logic.GetNextIdFree() - 1;

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
            expectedRoutes.Add(expectedRoute2);
            expectedRoutes.Add(expectedRoute1);
            List<Route> obtainRoutes = schoolVanLogic.GetBestRoutes();

            Assert.IsTrue(obtainRoutes.SequenceEqual(expectedRoutes));
        }
        [TestMethod]
        public void GetFirstNextIdFree()
        {
            SetUp();
            SchoolVanLogic testLogic = new SchoolVanLogic();
            int expectedValue = 1;
            Assert.IsTrue(testLogic.GetNextIdFree().Equals(expectedValue));
        }
        [TestMethod]
        public void GetNextIdFreeSuccess()
        {
            SetUp();
            SchoolVanLogic testLogic = new SchoolVanLogic();
            SchoolVan newSchoolVan = new SchoolVan();
            newSchoolVan.Id = 1;
            newSchoolVan.Capacity = 2;
            testLogic.Add(newSchoolVan);
            int expectedValue = 0;
            Assert.IsFalse(testLogic.GetNextIdFree().Equals(expectedValue));
        }
    }
}
