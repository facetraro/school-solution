using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void CompareStudentSuccess()
        {
            Student aStudent = new Student();
            int testId = 123;
            aStudent.Id = testId;
            Student anotherStudent = new Student();
            anotherStudent.Id = testId;
            Assert.IsTrue(aStudent.Equals(anotherStudent));
        }
        [TestMethod]
        public void ConstructorStudentSuccess()
        {
            Student aStudent = new Student();
            aStudent.Id = 1;
            aStudent.Name = "TestName";
            aStudent.LastName = "TestLastName";
            Coordinate aCoordinate = new Coordinate();
            aCoordinate.X = 1;
            aCoordinate.Y = 2;
            aStudent.Coordinates = aCoordinate;
            aStudent.Ci = 47801236;
            aStudent.StudentNumber = 193221;
            aStudent.Subjects = new List<Subject>();
            Assert.IsTrue(aStudent.Name.Equals("TestName"));
            Assert.IsTrue(aStudent.LastName.Equals("TestLastName"));
            Assert.IsTrue(aStudent.Coordinates.Equals(aCoordinate));
            Assert.IsTrue(aStudent.Ci.Equals(47801236));
            Assert.IsTrue(aStudent.StudentNumber.Equals(193221));
            Assert.IsTrue(aStudent.Subjects.Equals(new List<Subject>());
        }
    }
}
