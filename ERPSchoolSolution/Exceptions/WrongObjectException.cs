using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    [ExcludeFromCodeCoverage]
    public class WrongObjectException : Exception
    {
        public WrongObjectException(string message) : base(message)
        {
        }
    }
}
