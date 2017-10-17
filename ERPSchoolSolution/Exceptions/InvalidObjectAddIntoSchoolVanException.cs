using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class InvalidObjectAddIntoSchoolVanException : Exception
    {
        public InvalidObjectAddIntoSchoolVanException(string message) : base(message)
        {
        }
    }
}
