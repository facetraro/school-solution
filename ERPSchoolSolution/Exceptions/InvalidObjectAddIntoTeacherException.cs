using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class InvalidObjectAddIntoTeacherException : Exception
    {
        public InvalidObjectAddIntoTeacherException(string message) : base(message)
        {
        }
    }
}
