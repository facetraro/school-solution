using System;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class SchoolVanTest
    {
        [TestMethod]
        public void CompareSchoolVanSuccess()
        {
            SchoolVan aVan = new SchoolVan();
            SchoolVan anotherVan = new SchoolVan();
            int aTestId = 1;
            aVan.Id = aTestId;
            anotherVan.Id = aTestId;
            Assert.IsTrue(aVan.Equals(anotherVan));
        }
        [TestMethod]
        public void CompareSchoolVanFail()
        {
            SchoolVan aVan = new SchoolVan();
            SchoolVan anotherVan = new SchoolVan();
            int aTestId = 1;
            int anotherTestId = 2;
            aVan.Id = aTestId;
            anotherVan.Id = anotherTestId;
            Assert.IsFalse(aVan.Equals(anotherVan));
        }
        [TestMethod]
        public void CompareSchoolVanDifferentObject()
        {
            SchoolVan aVan = new SchoolVan();
            SchoolVan anotherVan = new SchoolVan();
            int aTestId = 1;
            int test = 4;
            aVan.Id = aTestId;
            Assert.IsFalse(aVan.Equals(test));
        }
        [TestMethod]
        public void ConstructorSchoolVanIdSuccess()
        {
            int aId = 1;
            int capacity = 5;
            SchoolVan aVan = new SchoolVan();
            aVan.Id = aId;
            aVan.Capacity = capacity;
            Assert.IsTrue(aVan.Id.Equals(aId));
            Assert.IsTrue(aVan.Capacity.Equals(capacity));
        }
        [TestMethod]
        public void ValidSchoolVanCapacity()
        {
            int aId = 1;
            int capacity = 5;
            SchoolVan aVan = new SchoolVan();
            aVan.Id = aId;
            aVan.Capacity = capacity;
            SchoolVanValidator validator=new SchoolVanValidator();
            Assert.IsTrue(validator.IsValid(aVan));
        }
        [TestMethod]
        public void OutOfBandsSchoolVanCapacity()
        {
            int aId = 1;
            int capacity = 2000;
            SchoolVan aVan = new SchoolVan();
            aVan.Id = aId;
            aVan.Capacity = capacity;
            SchoolVanValidator validator = new SchoolVanValidator();
            Assert.IsFalse(validator.IsValid(aVan));
        }

        [TestMethod]
        public void toStringSubject()
        {
            SchoolVan aSchoolVan = new SchoolVan();
            aSchoolVan.Id = 123;
            aSchoolVan.Capacity = 10;
            Assert.IsTrue(aSchoolVan.ToString().Equals("Camioneta: 123 [Capacidad 10]"));

        }
    }
}
