using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERPSchoolValidator;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.CodeAnalysis;

namespace Testing
{
    [TestClass]
    [ExcludeFromCodeCoverage]

    public class SortStudentsTest
    {
        [TestMethod]
        public void SortStudentFail()
        {
            List<Student> toSort = new List<Student>();
            Student firstTestStudent = new Student();
            Student secondTestStudent = new Student();
            Student thirdTestStudent = new Student();
            firstTestStudent.Id = 4;
            secondTestStudent.Id = 2;
            thirdTestStudent.Id = 3;
            toSort.Add(firstTestStudent);
            toSort.Add(secondTestStudent);
            toSort.Add(thirdTestStudent);
            List<Student> expectedList = new List<Student>();
            expectedList.Add(secondTestStudent);
            expectedList.Add(firstTestStudent);
            expectedList.Add(thirdTestStudent);
            SortStudents sort = new SortStudents();
            Assert.IsFalse(expectedList.SequenceEqual(sort.GenerateSortedList(toSort)));
        }
        [TestMethod]
        public void SortStudentSuccess()
        {
            List<Student> toSort = new List<Student>();
            Student firstTestStudent = new Student();
            Student secondTestStudent = new Student();
            Student thirdTestStudent = new Student();
            firstTestStudent.Id = 4;
            secondTestStudent.Id = 2;
            thirdTestStudent.Id = 3;
            toSort.Add(firstTestStudent);
            toSort.Add(secondTestStudent);
            toSort.Add(thirdTestStudent);
            List<Student> expectedList = new List<Student>();
            expectedList.Add(secondTestStudent);
            expectedList.Add(thirdTestStudent);
            expectedList.Add(firstTestStudent);
            SortStudents sort = new SortStudents();
            List<Student> obtainedList = sort.GenerateSortedList(toSort);
            Assert.IsTrue(expectedList.SequenceEqual(obtainedList));
        }
    }
}
