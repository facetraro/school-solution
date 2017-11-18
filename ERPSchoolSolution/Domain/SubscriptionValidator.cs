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
            Subscription theSubscription = anObject as Subscription;
            if ((System.Object)theSubscription == null)
            {
                throw new InvalidObjectAddIntoSubscriptionException("Se esperaba un objeto del tipo [Subscription]");
            }
            return true;
        }
    }
}