using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Exceptions;

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
    }
}
