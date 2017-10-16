using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Exceptions;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class RouteTest
    {
        private Student TestStudent()
        {
            Student testStudent = new Student();
            testStudent.Id = 54;
            testStudent.Ci = 47642349;
            testStudent.Name = "TestName";
            testStudent.LastName = "TestLastName";
            return testStudent;
        }
        [TestMethod]
        public void AddToRouteSuccess()
        {
            Route newRoute = new Route();
            Coordinate newCoordinate = new Coordinate();
            newRoute.Add(newCoordinate);
            Student newStudent = TestStudent();
            newRoute.Add(newStudent);
            Assert.IsTrue(newRoute.Length() == 2);
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
        [TestMethod]
        public void CalculateBasicDistance()
        {
            Route newRoute = new Route();
            Coordinate newCoordinate = new Coordinate();
            newRoute.Add(newCoordinate);
            Student newStudent = TestStudent();
            newRoute.Add(newStudent);
            Assert.IsTrue(newRoute.TotalDistance() == 0);
        }
        [TestMethod]
        public void CalculateSimpleDistance()
        {
            Route newRoute = new Route();
            Coordinate newCoordinate = new Coordinate();
            newCoordinate.X = 5;
            newRoute.Add(newCoordinate);
            Student newStudent = TestStudent();
            newStudent.Coordinates.X = 5;
            newStudent.Coordinates.Y = 5;
            newRoute.Add(newStudent);
            Assert.IsTrue(newRoute.TotalDistance() == 10);
        }

        [TestMethod]
        public void RouteEqualsSuccess()
        {
            Route newRoute = new Route();
            Coordinate newCoordinate = new Coordinate();
            newCoordinate.X = 5;
            newRoute.Add(newCoordinate);
            Student newStudent = new Student();
            newStudent.Id = 4;
            newRoute.Add(newStudent);

            Route anotherEqualsRoute = new Route();
            Coordinate anotherEqualsCoordinate = new Coordinate();
            anotherEqualsCoordinate.X = 5;
            anotherEqualsRoute.Add(anotherEqualsCoordinate);
            Student anotherEqualsStudent = new Student();
            anotherEqualsStudent.Id = 4;
            anotherEqualsRoute.Add(anotherEqualsStudent);

            Assert.IsTrue(newRoute.Equals(anotherEqualsRoute));
        }
        [TestMethod]
        public void RouteEqualsFail()
        {
            Route newRoute = new Route();
            Coordinate newCoordinate = new Coordinate();
            newCoordinate.X = 5;
            newRoute.Add(newCoordinate);
            Student newStudent = new Student();
            newStudent.Id = 4;
            newRoute.Add(newStudent);

            Route anotherEqualsRoute = new Route();
            Coordinate anotherEqualsCoordinate = new Coordinate();
            anotherEqualsCoordinate.X = 5;
            anotherEqualsRoute.Add(anotherEqualsCoordinate);
            Student anotherEqualsStudent = new Student();
            anotherEqualsStudent.Id = 5;
            anotherEqualsRoute.Add(anotherEqualsStudent);

            Assert.IsTrue(newRoute.Equals(anotherEqualsRoute));
        }

        [TestMethod]
        public void toStringRoute()
        {

            Route aRoute = new Route();
            Coordinate newCoordinate = new Coordinate();
            newCoordinate.X = 12;
            newCoordinate.Y = 1;
            aRoute.Add(newCoordinate);
            string ruta = aRoute.ToStringRoute();
            Assert.IsTrue(ruta.Equals("Ruta Camioneta: [12,1]"));

        }
        [TestMethod]
        public void AreEqualsSuccess()
        {
            SchoolVan aSchoolVan = new SchoolVan();
            SchoolVan anotherSchoolVan = new SchoolVan();
            aSchoolVan.Id = 1;
            anotherSchoolVan.Id = 1;
            List<Route> aListRoute = new List<Route>();
            Route aNewRoute = new Route();
            int expectedLength = 1;
            aListRoute.Add(aNewRoute);

            Assert.IsTrue(aSchoolVan.Equals(anotherSchoolVan) && aListRoute.Count == expectedLength);

        }
    }
}
