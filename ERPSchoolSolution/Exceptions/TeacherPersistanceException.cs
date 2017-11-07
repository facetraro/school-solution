using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class TeacherPersistanceException : Exception
    {
        public TeacherPersistanceException(string message) : base(message)
        {
        }
    }
}
