using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class TeacherAlreadyExistsException : Exception
    {
        public TeacherAlreadyExistsException(string message) : base(message)
        {
        }
    }
}
