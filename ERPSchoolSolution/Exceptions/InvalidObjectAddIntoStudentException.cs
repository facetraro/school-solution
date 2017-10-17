using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class InvalidObjectAddIntoStudentException : Exception
    {
        public InvalidObjectAddIntoStudentException(string message) : base(message)
        {
        }
    }
}
