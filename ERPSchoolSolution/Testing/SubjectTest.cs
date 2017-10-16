using System;
using System.Linq;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class SubjectTest
    {
        [TestMethod]
        public void CompareSubjectSuccess()
        {
            Subject aSubject = new Subject();
            string subject = "A3";
            aSubject.Code = subject;
            Subject anotherSubject = new Subject();
            anotherSubject.Code = subject;
            Assert.IsTrue(aSubject.Equals(anotherSubject));
        }
        [TestMethod]
        public void CompareSubjectFail()
        {
            Subject aSubject = new Subject();
            string subject1 = "A3";
            string subject2 = "A2";
            aSubject.Code = subject1;
            Subject anotherSubject = new Subject();
            anotherSubject.Code = subject2;
            Assert.IsFalse(aSubject.Equals(anotherSubject));
        }
        [TestMethod]
        public void SubjectCodeNotEmpty()
        {
            Subject aSubject = new Subject();
            aSubject.Code = null;
            SubjectValidator validator = new SubjectValidator();
            Assert.IsFalse(validator.IsValid(aSubject));
        }
        [TestMethod]
        public void SubjectConstructorSuccess()
        {
            string testCode = "AJ55";
            string testName = "Mathematics";
            Subject aSubject = new Subject();
            aSubject.Code = testCode;
            aSubject.Name = testName;
            Student aStudent = new Student();
            aStudent.Id = 123;
            aStudent.StudentNumber = 123;
            Teacher aTeacher = new Teacher();
            aTeacher.Id = 1234;
            aSubject.Students.Add(aStudent);
            aSubject.Teachers.Add(aTeacher);
            Assert.IsTrue(aSubject.Teachers.ElementAt(0).Equals(aTeacher));
            Assert.IsTrue(aSubject.Students.ElementAt(0).Equals(aStudent));
            Assert.IsTrue(aSubject.Code.Equals(testCode));
            Assert.IsTrue(aSubject.Name.Equals(testName));
        }
        [TestMethod]
        public void toStringSubject()
        {
            Subject aSubject = new Subject();
            aSubject.Code = "123";
            aSubject.Name = "test";
            Assert.IsTrue(aSubject.ToString().Equals("Materia: test [123]"));

        }
        [TestMethod]
        public void CompareSubjectNull()
        {
            int aInt = 3;
            Subject anotherSubject = new Subject();
            Assert.IsFalse(anotherSubject.Equals(aInt));
        }

    }
}
