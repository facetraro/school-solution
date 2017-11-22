using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions 
{
    public class ActivityPaymentPersistanceException : Exception
    {
        public ActivityPaymentPersistanceException(string message) : base(message)
        {
        }
    }
}
