using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class SchoolVanAlreadyExistsException : Exception
    {
        public SchoolVanAlreadyExistsException(string message) : base(message)
        {
        }
    }
}
