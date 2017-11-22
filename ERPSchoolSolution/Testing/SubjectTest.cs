using System;
using System.Linq;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exceptions;
using System.Diagnostics.CodeAnalysis;

namespace Testing
{
    [TestClass]
    [ExcludeFromCodeCoverage]

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
        [ExpectedException(typeof(EmptyOrNullValueException))]
        public void SubjectCodeNotEmpty()
        {
            Subject aSubject = new Subject();
            aSubject.Code = null;
            SubjectValidator validator = new SubjectValidator();
            validator.IsValid(aSubject);
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
            int testId = 123;
            aStudent.StudentNumber = testId;
            Teacher aTeacher = new Teacher();
            int anotherTestId = 1234;
            aTeacher.Id = anotherTestId;
            aSubject.Students.Add(aStudent);
            aSubject.Teachers.Add(aTeacher);
            Assert.IsTrue(aSubject.Code.Equals(testCode));
            Assert.IsTrue(aSubject.Name.Equals(testName));
            Assert.IsTrue(aSubject.Teachers.ElementAt(0).Equals(aTeacher));
            Assert.IsTrue(aSubject.Students.ElementAt(0).Equals(aStudent));
        }
        [TestMethod]
        public void toStringSubject()
        {
            Subject aSubject = new Subject();
            aSubject.Code = "123";
            aSubject.Name = "test";
            Assert.IsTrue(aSubject.ToString().Equals("test [123]"));

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
