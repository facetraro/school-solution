using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class StudentPersistanceException : Exception
    {
        public StudentPersistanceException(string message) : base(message)
        {
        }
    }
}
