using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Route
    {
        private List<Object> theRoute { get; set; }
        public Route()
        {
            theRoute = new List<Object>();
        }
        public List<Object> TheRoute
        {
            get
            {
                return this.theRoute;
            }
            set
            {
                this.theRoute = value;
            }
        }
        private bool IsACoordinate(Object anObject)
        {
            return (anObject is Coordinate);
        }
        private bool IsAStudent(Object anObject)
        {
            return (anObject is Student);
        }
        private bool IsARouteObject(Object anObject)
        {
            return IsACoordinate(anObject) || IsAStudent(anObject);
        }
        public void AddIntoRoute(Object anObject)
        {
            this.theRoute.Add(anObject);
        }
        public void Add(Object anObject)
        {
            if (IsARouteObject(anObject))
            {
                AddIntoRoute(anObject);
            }
            else
            {
                throw new InvalidObjectAddIntoRouteSystemException("Invalid object into Route");
            }
        }

        public int TotalDistance()
        {
            int totalDistance = 0;
            Coordinate actualCoordinate = new Coordinate();
            foreach (Object anObject in this.theRoute)
            {
                if (this.IsAStudent(anObject))
                {
                    Student aStudent = anObject as Student;
                    totalDistance = totalDistance + actualCoordinate.GetDistanceOf(aStudent.Coordinates);
                    actualCoordinate = aStudent.Coordinates;
                }
                if (this.IsACoordinate(anObject))
                {
                    Coordinate aCoordinate = anObject as Coordinate;
                    totalDistance = totalDistance + actualCoordinate.GetDistanceOf(aCoordinate);
                    actualCoordinate = aCoordinate;
                }
            }

            return totalDistance;
        }
        public int Length()
        {
            return this.theRoute.Count;
        }
    }
}
