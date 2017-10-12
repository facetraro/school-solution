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

        }
        public int Length()
        {
            return 2;
        }
    }
}
