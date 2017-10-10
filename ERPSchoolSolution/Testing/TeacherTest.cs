using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace Testing
{
    [TestClass]
    public class TeacherTest
    {
        [TestMethod]
        public void CompareTeacherSuccess()
        {
            Teacher aTeacher = new Teacher();
            int id = 123;
            aTeacher.Id = id;

            Teacher anotherTeacher = new Teacher();
            anotherTeacher.Id = id;
            Assert.IsTrue(aTeacher.Equals(anotherTeacher));
            
        }
    }
}
