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
        private List<IRouteObject> theRoute { get; set; }
        public Route()
        {
            theRoute = new List<IRouteObject>();
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
        private bool IsARouteObject(Object anObject)
        {
            return (anObject is IRouteObject);
        }
        public void AddIntoRoute(Object anObject)
        {
            IRouteObject toAdd = anObject as IRouteObject;
            this.theRoute.Add(toAdd);
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
