using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Exceptions;

namespace Testing
{
    [TestClass]
    public class RouteTest
    {
        [TestMethod]
        public void AddToRouteSuccess()
        {
            Route newRoute = new Route();
            Coordinate newCoordinate = new Coordinate();
            newRoute.Add(newCoordinate);
            Student newStudent = new Student();
            newRoute.Add(newStudent);
            Assert.IsTrue(newRoute.Length()==2);
        }
        [ExpectedException(typeof(InvalidObjectAddIntoRouteSystemException))]
        [TestMethod]
        public void AddToRouteFail()
        {
            Route newRoute = new Route();
            Coordinate newCoordinate = new Coordinate();
            newRoute.Add(newCoordinate);
            int invalidObjectRoute = 5;
            newRoute.Add(invalidObjectRoute);
        }
    }
}
