using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class TeacherTest
    {
        [TestMethod]
        public void CompareTeacherSuccess()
        {
            Teacher aTeacher = new Teacher();
            aTeacher.Id = 123;

            Teacher anotherTeacher = new Teacher();
            anotherTeacher.Id = 123;
            Assert.IsTrue(aTeacher.Equals(anotherTeacher));
            
        }
    }
}
