using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Route
    {
        public List<Object> TheRoute { get; set; }
        public void Add(Object anObject)
        {

        }
        public int Length()
        {
            return 2;
        }
    }
}
