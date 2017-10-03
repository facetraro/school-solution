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
            SchoolVan aVan = new SchoolVan(aId, capacity);
            SchoolVan anotherVan = new SchoolVan();
            anotherVan.Id = aId;
            Assert.IsTrue(aVan.Equals(anotherVan));
        }
        [TestMethod]
        public void ValidSchoolVanCapacity()
        {
            SchoolVan aVan = new SchoolVan(1, 10);
            Assert.IsTrue(aVan.IsValid());
        }
    }
}
