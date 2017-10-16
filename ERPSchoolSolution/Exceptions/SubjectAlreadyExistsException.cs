using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class SubjectAlreadyExistsException : Exception
    {
        public SubjectAlreadyExistsException(string message) : base(message)
        {
        }
    }
}
