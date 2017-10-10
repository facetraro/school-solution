using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using System.Collections.Generic;

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
            int testId = 123;
            aTeacher.Id = testId;
            string nameTest = "Ricardo";
            aTeacher.Name = nameTest;
            string lastNameTest = "Gonzalez";
            aTeacher.LastName = lastNameTest;
            List<Subject> listSubject = new List<Subject>();
            aTeacher.Subjects = listSubject;
            Assert.IsTrue(aTeacher.Id.Equals(testId));
            Assert.IsTrue(aTeacher.Name.Equals(nameTest));
            Assert.IsTrue(aTeacher.LastName.Equals(lastNameTest));
            Assert.IsTrue(aTeacher.Subjects.Equals(listSubject));
        }

    }
}
