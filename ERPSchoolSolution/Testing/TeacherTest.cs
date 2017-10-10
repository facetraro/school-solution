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
        [TestMethod]
       public void ConstructorTeacherTest()
        {
            Teacher aTeacher = new Teacher();
            aTeacher.Id = 123;
            aTeacher.Name = "TestName";
            aTeacher.LastName = "TestLastName";
            aTeacher.Subjects = List<Subject>();
            Assert.IsTrue(aTeacher.Name.Equals("TestName"));
            Assert.IsTrue(aTeacher.LastName.Equals("TestLastName"));
            Assert.IsTrue(aTeacher.Subjects.Equals(new List<Subject>()));
        }
    }
}
