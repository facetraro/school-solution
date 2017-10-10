using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Logic;

namespace Testing.LogicTest
{
    [TestClass]
    public class SchoolVanLogicTest
    {
        public void ClearRepository()
        {
            SchoolVanLogic testLogic = new SchoolVanLogic();
            testLogic.Empty();
        }
        public void SetUp()
        {
            ClearRepository();
        }
        [TestMethod]
        public void AddSchoolVanSuccess()
        {
            SetUp();
            SchoolVan newSchoolVan = new SchoolVan();
            SchoolVanLogic testLogic = new SchoolVanLogic();
            testLogic.Add(newSchoolVan);
            Assert.IsTrue(testLogic.Exists(newSchoolVan));
        }
        [TestMethod]
        public void ExistsSchoolVanFail()
        {
            SetUp();
            SchoolVan newSchoolVan = new SchoolVan();
            SchoolVanLogic testLogic = new SchoolVanLogic();
            Assert.IsFalse(testLogic.Exists(newSchoolVan));
        }
    }
}
