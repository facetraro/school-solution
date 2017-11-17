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
            Insert(aSubscription);
        }
        private void Insert(Subscription toAdd)
        {
            SubscriptionAccess context = new SubscriptionAccess();
            context.Add(toAdd);
        }
        public bool Exists(Object anObject)
        {
            SubscriptionAccess context = new SubscriptionAccess();
            Subscription lookUp = anObject as Subscription;
            bool exists = GetAllSubscriptions().Contains(lookUp);
            return exists;
        }
        public List<Subscription> GetAllSubscriptions()
        {
            SubscriptionAccess context = new SubscriptionAccess();
            return context.GetAll();
        }
    }
}
