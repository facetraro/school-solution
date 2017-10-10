using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
namespace Testing.LogicTest
{
    [TestClass]
    public class SubjectLogicTest
    {
        [TestMethod]
        public void AddSubjectSuccess()
        {
            Subject newSubjectTest = new Subject();
            SubjectLogic testLogic = new SubjectLogic();
            testLogic.Add(newSubjectTest);
            Assert.IsTrue(testLogic.Exists(newSubjectTest));
        }
        
    }
}
