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
            aVan.Id = 1;
            anotherVan.Id = 1;
            Assert.IsTrue(aVan.Equals(anotherVan));
        }
    }
}
