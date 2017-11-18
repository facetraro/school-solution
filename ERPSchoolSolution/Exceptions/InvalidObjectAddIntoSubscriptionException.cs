using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class InvalidObjectAddIntoSubscriptionException : Exception
    {
        public InvalidObjectAddIntoSubscriptionException(string message) : base(message)
        {
        }
    }
}
