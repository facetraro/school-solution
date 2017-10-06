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
            int xCoordinateTest = 1;
            int yCoordinateTest = 1;
            aCoordinate.X = xCoordinateTest;
            aCoordinate.Y = 1;
            Coordinate anotherCoordinate = new Coordinate();
            anotherCoordinate.X = xCoordinateTest;
            anotherCoordinate.Y = yCoordinateTest;
            Assert.IsTrue(aCoordinate.Equals(anotherCoordinate));
        }
        [TestMethod]
        public void CompareCoordinateFail()
        {
            Coordinate aCoordinate = new Coordinate();
            int xCoordinateTest = 1;
            int yCoordinateTest = 1;
            int xDifferentCoordinateTest = 3;
            int yDifferentCoordinateTest = 5;
            aCoordinate.X = xCoordinateTest;
            aCoordinate.Y = 1;
            Coordinate anotherCoordinate = new Coordinate();
            anotherCoordinate.X = xDifferentCoordinateTest;
            anotherCoordinate.Y = yDifferentCoordinateTest;
            Assert.IsFalse(aCoordinate.Equals(anotherCoordinate));
        }
    }
}
