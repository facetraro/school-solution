using System;
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
            string subject1 = "A3";
            string subject2 = "A2";
            aSubject.Code = subject1;
            Subject anotherSubject = new Subject();
            anotherSubject.Code = subject2;
            Assert.IsFalse(aSubject.Equals(anotherSubject));
        }
        [TestMethod]
        public void SubjectCodeNotEmpty()
        {
            Subject aSubject = new Subject();
            aSubject.Code = null;
            Assert.IsFalse(aSubject.IsValid());
        }
        [TestMethod]
        public void SubjectConstructorSuccess()
        {
            string testCode = "AJ55";
            string testName = "Mathematics";
            Subject aSubject = new Subject();
            aSubject.Code = testCode;
            aSubject.Name = testName;
            Subject anotherSubject = new Subject("AJ55", "Mathematics");
            Assert.IsTrue(aSubject.Equals(anotherSubject));
        }

    }
}
