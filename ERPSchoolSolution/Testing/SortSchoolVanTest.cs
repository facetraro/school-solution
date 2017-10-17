using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.CodeAnalysis;

namespace Testing
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class SortSchoolVanTest
    {
        [TestMethod]
        public void SortSchoolVanFail()
        {
            List<SchoolVan> toSort = new List<SchoolVan>();
            SchoolVan firstTestSchoolVan = new SchoolVan();
            SchoolVan secondTestSchoolVan = new SchoolVan();
            SchoolVan thirdTestSchoolVan = new SchoolVan();
            firstTestSchoolVan.Id = 4;
            secondTestSchoolVan.Id = 2;
            thirdTestSchoolVan.Id = 3;
            firstTestSchoolVan.Capacity = 4;
            secondTestSchoolVan.Capacity = 2;
            thirdTestSchoolVan.Capacity = 3;
            toSort.Add(firstTestSchoolVan);
            toSort.Add(secondTestSchoolVan);
            toSort.Add(thirdTestSchoolVan);
            List<SchoolVan> expectedList = new List<SchoolVan>();
            expectedList.Add(thirdTestSchoolVan);
            expectedList.Add(firstTestSchoolVan);
            expectedList.Add(secondTestSchoolVan);
            SortSchoolVans sort = new SortSchoolVans();
            List<SchoolVan> ObtainedList = sort.GenerateSortedList(toSort);
            bool result = expectedList.SequenceEqual(ObtainedList);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void SortSchoolVanSuccess()
        {
            List<SchoolVan> toSort = new List<SchoolVan>();
            SchoolVan firstTestSchoolVan = new SchoolVan();
            SchoolVan secondTestSchoolVan = new SchoolVan();
            SchoolVan thirdTestSchoolVan = new SchoolVan();
            firstTestSchoolVan.Id = 4;
            secondTestSchoolVan.Id = 2;
            thirdTestSchoolVan.Id = 3;
            firstTestSchoolVan.Capacity = 4;
            secondTestSchoolVan.Capacity = 2;
            thirdTestSchoolVan.Capacity = 3;
            toSort.Add(firstTestSchoolVan);
            toSort.Add(secondTestSchoolVan);
            toSort.Add(thirdTestSchoolVan);
            List<SchoolVan> expectedList = new List<SchoolVan>();
            expectedList.Add(firstTestSchoolVan);
            expectedList.Add(thirdTestSchoolVan);
            expectedList.Add(secondTestSchoolVan);
            SortSchoolVans sort = new SortSchoolVans();
            List<SchoolVan> ObtainedList = sort.GenerateSortedList(toSort);
            bool result = expectedList.SequenceEqual(ObtainedList);
            Assert.IsTrue(result);
        }
    }
}
