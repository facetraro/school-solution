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
        public int Length()
        {
            return this.theRoute.Count;
        }
    }
}
