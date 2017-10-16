using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class EmptyOrNullValueException : Exception
    {
        public EmptyOrNullValueException(string message) : base(message)
        {
        }
    }
}
