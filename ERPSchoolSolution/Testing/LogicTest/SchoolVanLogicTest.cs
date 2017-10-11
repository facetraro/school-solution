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
            int expectedSchoolVanListLength = 1;
            Assert.IsTrue(testLogic.Length() == expectedSchoolVanListLength);
        }
        [TestMethod]
        public void AddSchoolVanDifferentObjectFail()
        {
            SetUp();
            SchoolVanLogic testLogic = new SchoolVanLogic();
            int test = 0;
            testLogic.Add(test);
            int expectedSchoolVanListLength = 0;
            Assert.IsTrue(testLogic.Length() == expectedSchoolVanListLength);
        }
        [TestMethod]
        public void AddInvalidSchoolVan()
        {
            SetUp();
            SchoolVan newSchoolVan = new SchoolVan();
            newSchoolVan.Capacity = -30;
            SchoolVanLogic testLogic = new SchoolVanLogic();
            testLogic.Add(newSchoolVan);
            Assert.IsFalse(testLogic.Exists(newSchoolVan));
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
        public void DeleteSchoolDifferentObjectFail()
        {
            SetUp();
            SchoolVan newSchoolVan = new SchoolVan();
            SchoolVanLogic testLogic = new SchoolVanLogic();
            int testInt = 0;
            testLogic.Add(newSchoolVan);
            testLogic.Remove(testInt);
            Assert.IsTrue(testLogic.Exists(newSchoolVan));
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
        public void DeleteSchoolVanFail()
        {
            SetUp();
            SchoolVan newSchoolVan = new SchoolVan();
            newSchoolVan.Id = 5;
            SchoolVan anotherSchoolVan = new SchoolVan();
            anotherSchoolVan.Id = 6;
            SchoolVanLogic testLogic = new SchoolVanLogic();
            testLogic.Add(newSchoolVan);
            testLogic.Remove(anotherSchoolVan);
            Assert.IsTrue(testLogic.Exists(newSchoolVan));
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
        [TestMethod]
        public void ModifySchoolVanSuccess()
        {
            SetUp();
            SchoolVan schoolVan = new SchoolVan();
            schoolVan.Id = 4;
            SchoolVanLogic testLogic = new SchoolVanLogic();
            SchoolVan editedSchoolVan = new SchoolVan();
            editedSchoolVan.Id = 50;
            testLogic.Add(schoolVan);
            testLogic.Modify(schoolVan, editedSchoolVan);
            Assert.IsTrue(testLogic.Exists(editedSchoolVan));

        }
        [TestMethod]
        public void ModifySchoolVanModifyNonExistent()
        {
            SetUp();
            SchoolVan schoolVan = new SchoolVan();
            schoolVan.Id = 4;
            SchoolVanLogic testLogic = new SchoolVanLogic();
            SchoolVan editedSchoolVan = new SchoolVan();
            editedSchoolVan.Id = 50;
            testLogic.Modify(schoolVan, editedSchoolVan);
            Assert.IsFalse(testLogic.Exists(editedSchoolVan));
        }
    }
}
