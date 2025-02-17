﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERPSchoolValidator;
using System.Diagnostics.CodeAnalysis;

namespace Testing
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class CoordinateTest
    {
        [TestMethod]
        public void CompareCoordinateSuccess()
        {
            Coordinate aCoordinate = new Coordinate();
            int xCoordinateTest = 1;
            int yCoordinateTest = 1;
            aCoordinate.X = xCoordinateTest;
            aCoordinate.Y = yCoordinateTest;
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
            aCoordinate.Y = yCoordinateTest;
            Coordinate anotherCoordinate = new Coordinate();
            anotherCoordinate.X = xDifferentCoordinateTest;
            anotherCoordinate.Y = yDifferentCoordinateTest;
            Assert.IsFalse(aCoordinate.Equals(anotherCoordinate));
        }
        [TestMethod]
        public void GetDistanceOfSuccessTest()
        {
            Coordinate aCoordinate = new Coordinate();
            int xCoordinateTest = 0;
            int yCoordinateTest = 0;
            int xDifferentCoordinateTest = 0;
            int yDifferentCoordinateTest = 0;
            aCoordinate.X = xCoordinateTest;
            aCoordinate.Y = yCoordinateTest;
            Coordinate anotherCoordinate = new Coordinate();
            anotherCoordinate.X = xDifferentCoordinateTest;
            anotherCoordinate.Y = yDifferentCoordinateTest;
            int coordinateDistance = aCoordinate.GetDistanceOf(anotherCoordinate);
            int expectedDistance = 0;
            Assert.IsTrue(coordinateDistance==expectedDistance);
        }
        [TestMethod]
        public void GetDistanceOf2SuccessTest()
        {
            Coordinate aCoordinate = new Coordinate();
            int xCoordinateTest = 0;
            int yCoordinateTest = 0;
            int xDifferentCoordinateTest = 4;
            int yDifferentCoordinateTest = 0;
            aCoordinate.X = xCoordinateTest;
            aCoordinate.Y = yCoordinateTest;
            Coordinate anotherCoordinate = new Coordinate();
            anotherCoordinate.X = xDifferentCoordinateTest;
            anotherCoordinate.Y = yDifferentCoordinateTest;
            int coordinateDistance = aCoordinate.GetDistanceOf(anotherCoordinate);
            int expectedDistance = 4;
            Assert.IsTrue(coordinateDistance == expectedDistance);
        }
        [TestMethod]
        public void GetDistanceOf3SuccessTest()
        {
            Coordinate aCoordinate = new Coordinate();
            int xCoordinateTest = 4;
            int yCoordinateTest = 0;
            int xDifferentCoordinateTest = 0;
            int yDifferentCoordinateTest = 0;
            aCoordinate.X = xCoordinateTest;
            aCoordinate.Y = yCoordinateTest;
            Coordinate anotherCoordinate = new Coordinate();
            anotherCoordinate.X = xDifferentCoordinateTest;
            anotherCoordinate.Y = yDifferentCoordinateTest;
            int coordinateDistance = aCoordinate.GetDistanceOf(anotherCoordinate);
            int expectedDistance = 4;
            Assert.IsTrue(coordinateDistance == expectedDistance);
        }
        [TestMethod]
        public void GetDistanceOf4SuccessTest()
        {
            Coordinate aCoordinate = new Coordinate();
            int xCoordinateTest = 4;
            int yCoordinateTest = 0;
            int xDifferentCoordinateTest = 0;
            int yDifferentCoordinateTest = 3;
            aCoordinate.X = xCoordinateTest;
            aCoordinate.Y = yCoordinateTest;
            Coordinate anotherCoordinate = new Coordinate();
            anotherCoordinate.X = xDifferentCoordinateTest;
            anotherCoordinate.Y = yDifferentCoordinateTest;
            int coordinateDistance = aCoordinate.GetDistanceOf(anotherCoordinate);
            int expectedDistance = 7;
            Assert.IsTrue(coordinateDistance == expectedDistance);
        }
    }
}
