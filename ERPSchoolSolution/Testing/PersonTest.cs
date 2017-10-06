using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
namespace Testing
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void ComparePersonSuccess()
        {
            Person aPerson = new Person();
            aPerson.Id = 123;
            Person anotherPerson = new Person();
            anotherPerson.Id = 123;
            Assert.IsTrue(aPerson.Equals(anotherPerson));
        }

        [TestMethod]
        public void PersonConstructorTest()
        {
            int testId = 123;
            string testName = "Charly";
            string testLastName = "Garcia";
            Person aPerson = new Person();
            aPerson.Id = testId;
            aPerson.Name = testName;
            aPerson.LastName = testLastName;
            Assert.IsTrue(aPerson.Id.Equals(testId));
            Assert.IsTrue(aPerson.Name.Equals(testName));
            Assert.IsTrue(aPerson.LastName.Equals(testLastName));
        }
    }
}
