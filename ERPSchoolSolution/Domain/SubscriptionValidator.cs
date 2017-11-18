using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SubscriptionValidator : IValidator
    {
        public bool IsValid(Object anObject)
        {
            return true;
        }
    }
}