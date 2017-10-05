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
    }
}
