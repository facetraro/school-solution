﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Logic;

namespace Testing.LogicTest
{
    [TestClass]
    public class SchoolVanLogicTest
    {
        [TestMethod]
        public void AddSchoolVanSuccess()
        {
            SchoolVan newSchoolVan = new SchoolVan();
            SchoolVanLogic testLogic = new SchoolVanLogic();
            testLogic.Add(newSchoolVan);
            Assert.IsTrue(testLogic.Exists(newSchoolVan));
        }
    }
}
