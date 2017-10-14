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
                return this.theSchoolVan;
            }
            set
            {
                this.theSchoolVan = value;
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
        public void RemoveLast()
        {
            if (this.Length() != 0)
            {
                this.theRoute.RemoveAt(this.Length() - 1);
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
        public Route Clone()
        {
            Route cloneRoute = new Route();
            cloneRoute.theSchoolVan.Capacity = this.theSchoolVan.Capacity;
            cloneRoute.theSchoolVan.Id = this.theSchoolVan.Id;
            foreach (IRouteObject anObject in this.theRoute)
            {
                cloneRoute.Add(anObject);
            }
            return cloneRoute;
        }
        private bool AreSameType(IRouteObject item, IRouteObject anotherItem)
        {
            return item.GetType().ToString().Equals(anotherItem.GetType().ToString());
        }
        private bool IsTheSameRoute(List<IRouteObject> list)
        {

            for (int i = 0; i < list.Count; i++)
            {
                IRouteObject item = list.ElementAt(i);
                if (!AreSameType(item,this.theRoute.ElementAt(i)))
                {
                    return false;
                }
                if (!item.GetCoordinates().Equals(this.theRoute.ElementAt(i).GetCoordinates()))
                {
                    return false;
                }
            }
            return true;
        }
        private bool AreEquals(Route theRoute)
        {
            return (theRoute.theSchoolVan.Equals(this.theSchoolVan) && this.Length() == theRoute.Length() && IsTheSameRoute(theRoute.theRoute));
        }
        public override bool Equals(object aRoute)
        {
            Route theRoute = aRoute as Route;
            return AreEquals(theRoute);
        }
    }
}
