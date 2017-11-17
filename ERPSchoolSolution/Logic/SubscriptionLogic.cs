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
        private bool CanIAdd(Object anObject)
        {
            bool validation = true;
            foreach (Subscription item in GetAllSubscriptions())
            {
                if(item.IsTheSameSubscription(anObject as Subscription))
                {
                    validation = false;
                    throw new AlreadySubscriptedException("El estudiante ya esta pago esa couta.");                   
                }
            }
            return validation;
        }
        public void Add(Object anObject)
        {
            if (CanIAdd(anObject))
            {
                Subscription aSubscription = anObject as Subscription;
                Insert(aSubscription);
            }
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

        public int Lenght()
        {
            return 1;
        }
    }
}
