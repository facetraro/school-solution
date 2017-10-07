using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

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
    }
}
