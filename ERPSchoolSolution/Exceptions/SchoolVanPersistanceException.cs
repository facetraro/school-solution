using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class SchoolVanPersistanceException : Exception
    {
        public SchoolVanPersistanceException(string message) : base(message)
        {
        }
    }
}
