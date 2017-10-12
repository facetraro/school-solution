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
        private List<IRouteObject> theRoute;
        private SchoolVan theSchoolVan;
        public Route()
        {
            theRoute = new List<IRouteObject>();
            theSchoolVan = new SchoolVan();
        }
        public List<IRouteObject> TheRoute
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
        public SchoolVan TheSchoolVan
        {
            get
            {
                return this.TheSchoolVan;
            }
            set
            {
                this.TheSchoolVan = value;
            }
        }
        private bool IsARouteObject(Object anObject)
        {
            return (anObject is IRouteObject);
        }
        private bool IsAStudent(Object anObject)
        {
            return (anObject is Student);
        }
        private void AddIntoRoute(Object anObject)
        {
            IRouteObject toAdd = anObject as IRouteObject;
            this.theRoute.Add(toAdd);
        }
        public bool IsStudentInRoute(Student lookUpStudent)
        {
            bool founded = false;
            foreach (IRouteObject anObject in this.theRoute)
            {
                if (IsAStudent(anObject))
                {
                    Student anObjectStudent = anObject as Student;
                    if (anObjectStudent.Equals(lookUpStudent))
                    {
                        founded = true;
                    }
                }
            }
            return founded;
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
        public int calculateDistanceObject(IRouteObject anObject, Coordinate actualCoordinate)
        {
            return anObject.GetCoordinates().GetDistanceOf(actualCoordinate);
        }
        public string ToStringRoute()
        {
            string stringRoute = "Ruta Camioneta: ";
            foreach (IRouteObject anObject in this.theRoute)
            {
                stringRoute = stringRoute + anObject.GetCoordinates().PrintCoordinate();     
            }
            return stringRoute;
        }
        public int TotalDistance()
        {
            int totalDistance = 0;
            Coordinate actualCoordinate = new Coordinate();
            foreach (IRouteObject anObject in this.theRoute)
            {
                totalDistance = totalDistance + calculateDistanceObject(anObject, actualCoordinate);
                actualCoordinate = anObject.GetCoordinates();
            }
            return totalDistance;
        }
        public int Length()
        {
            return this.theRoute.Count;
        }
    }
}
