using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class SubscriptionPersistanceException : Exception
    {
        public SubscriptionPersistanceException(string message) : base(message)
        {
        }
    }
}
