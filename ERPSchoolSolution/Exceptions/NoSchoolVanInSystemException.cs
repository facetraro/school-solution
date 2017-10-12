using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class NoSchoolVanInSystemException : Exception
    {
        public NoSchoolVanInSystemException(string message) : base(message)
        {
        }
    }
}
