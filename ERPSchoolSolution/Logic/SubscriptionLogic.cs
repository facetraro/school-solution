using Domain;
using Exceptions;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class SubscriptionLogic : IAdd
    {
        public void Add(Object anObject)
        {
            Subscription aSubscription = anObject as Subscription;
            SubscriptionAccess context = new SubscriptionAccess();
            context.Add(aSubscription);
        }
        public bool Exists(Object anObject)
        {
            SubscriptionAccess context = new SubscriptionAccess();
            Subscription lookUp = anObject as Subscription;
            bool exists = context.GetAll().Contains(lookUp);
            return exists;
        }
    }
}
