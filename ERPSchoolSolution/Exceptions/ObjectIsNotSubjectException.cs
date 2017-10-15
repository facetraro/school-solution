using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class ObjectIsNotSubjectException : Exception
    {
        public ObjectIsNotSubjectException(string message) : base(message)
        {
        }
    }
}
