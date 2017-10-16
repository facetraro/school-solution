using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class InvalidObjectAddIntoSubjectsException : Exception
    {
        public InvalidObjectAddIntoSubjectsException(string message) : base(message)
        {
        }
    }
}
