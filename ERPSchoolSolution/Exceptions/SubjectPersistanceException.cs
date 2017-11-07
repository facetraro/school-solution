using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class SubjectPersistanceException : Exception
    {
        public SubjectPersistanceException(string message) : base(message)
        {
        }
    }
}
