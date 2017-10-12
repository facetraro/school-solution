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
        public void Add(Object anObject)
        {
            if ((anObject is Coordinate)|| (anObject is Student))
            {
                if (anObject is Coordinate)
                {
                    this.theRoute.Add(anObject);
                }
                if (anObject is Student)
                {
                    this.theRoute.Add(anObject);
                }
            } else
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
