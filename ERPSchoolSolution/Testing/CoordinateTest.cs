using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace Testing
{
    [TestClass]
    public class CoordinateTest
    {
        [TestMethod]
        public void CompareCoordinateSuccess()
        {
            Coordinate aCoordinate = new Coordinate();
            aCoordinate.X = 1;
            aCoordinate.Y = 1;
            Coordinate anotherCoordinate = new Coordinate();
            aCoordinate.X = 1;
            aCoordinate.Y = 1;
            Assert.IsTrue(aCoordinate.Equals(anotherCoordinate));
        }
    }
}
