using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class InvalidObjectAddIntoRouteSystemException : Exception
    {
        public InvalidObjectAddIntoRouteSystemException(string message) : base(message)
        {
        }
    }
}
