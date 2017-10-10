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
        public void AddSchoolVanFail()
        {
            SetUp();
            SchoolVan newSchoolVan = new SchoolVan();
            SchoolVanLogic testLogic = new SchoolVanLogic();
            testLogic.Add(newSchoolVan);
            SchoolVan anotherNewSchoolVan = new SchoolVan();
            testLogic.Add(anotherNewSchoolVan);
            Assert.IsTrue(testLogic.Length()==1);
        }
        [TestMethod]
        public void ExistsSchoolVanFail()
        {
            SetUp();
            SchoolVan newSchoolVan = new SchoolVan();
            SchoolVanLogic testLogic = new SchoolVanLogic();
            Assert.IsFalse(testLogic.Exists(newSchoolVan));
        }
        [TestMethod]
        public void DeleteSchoolVanSuccess()
        {
            SetUp();
            SchoolVan newSchoolVan = new SchoolVan();
            SchoolVanLogic testLogic = new SchoolVanLogic();
            testLogic.Add(newSchoolVan);
            testLogic.Remove(newSchoolVan);
            Assert.IsFalse(testLogic.Exists(newSchoolVan));
        }
        [TestMethod]
        public void ModifySchoolVanFail()
        {
            SetUp();
            SchoolVan schoolVan = new SchoolVan();
            SchoolVanLogic testLogic = new SchoolVanLogic();
            SchoolVan editedSchoolVan = new SchoolVan();
            editedSchoolVan.Id = 50;
            testLogic.Add(schoolVan);
            testLogic.Modify(schoolVan, editedSchoolVan);
            Assert.IsFalse(testLogic.Exists(schoolVan));
        }
    }
}
