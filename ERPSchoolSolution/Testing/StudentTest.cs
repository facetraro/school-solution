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
            List<Subject> subjectList = new List<Subject>();
            aStudent.Subjects = subjectList;
            Assert.IsTrue(aStudent.Id.Equals(1));
            Assert.IsTrue(aStudent.Name.Equals("TestName"));
            Assert.IsTrue(aStudent.LastName.Equals("TestLastName"));
            Assert.IsTrue(aStudent.Coordinates.Equals(aCoordinate));
            Assert.IsTrue(aStudent.Ci.Equals(47801236));
            Assert.IsTrue(aStudent.StudentNumber.Equals(193221));
            Assert.IsTrue(aStudent.Subjects.Equals(subjectList));
        }
        [TestMethod]
        public void IsInscriptedSubjectSuccess()
        {
            Student aStudent = new Student();
            List<Subject> subjectList = new List<Subject>();
            Subject newSubject = new Subject();
            string code = "DA1";
            string name = "Diseño de Aplicaciones 1";
            newSubject.Code = code;
            newSubject.Name = name;
            subjectList.Add(newSubject);
            aStudent.Subjects = subjectList;
            Assert.IsTrue(aStudent.IsInscriptedSubject(newSubject));
        }
        [TestMethod]
        public void IsInscriptedSubjectFail()
        {
            Student aStudent = new Student();
            List<Subject> subjectList = new List<Subject>();
            Subject newSubject = new Subject();
            string code = "DA1";
            string name = "Diseño de Aplicaciones 1";
            newSubject.Code = code;
            newSubject.Name = name;
            Subject anotherSubject = new Subject();
            string anotherCode = "DA2";
            string anotherName = "Diseño de Aplicaciones 2";
            newSubject.Code = anotherCode;
            newSubject.Name = anotherName;
            subjectList.Add(newSubject);
            aStudent.Subjects = subjectList;
            Assert.IsFalse(aStudent.IsInscriptedSubject(anotherSubject));
        }
    }
}
