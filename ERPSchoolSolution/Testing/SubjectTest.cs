﻿using System;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class SubjectTest
    {
        [TestMethod]
        public void CompareSubjectSuccess()
        {
            Subject aSubject = new Subject();
            string subject = "A3";
            aSubject.Code = subject;
            Subject anotherSubject = new Subject();
            anotherSubject.Code = subject;
            Assert.IsTrue(aSubject.Equals(anotherSubject));
        }
        [TestMethod]
        public void CompareSubjectFail()
        {
            Subject aSubject = new Subject();
            aSubject.Code = "A3";
            Subject anotherSubject = new Subject();
            anotherSubject.Code = "A2";
            Assert.IsFalse(aSubject.Equals(anotherSubject));
        }
    }
}
