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
            aStudent.Id = 123;
            Student anotherStudent = new Student();
            anotherStudent.Id = 123;
            Assert.IsTrue(aStudent.Equals(anotherStudent));
        }
    }
}
