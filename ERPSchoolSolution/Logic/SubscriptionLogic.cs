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
        private bool StudentAlreadyPayThisMonth(Object anObject)
        {
            bool validation = false;
            foreach (Subscription item in GetAllSubscriptions())
            {
                if (item.IsTheSameSubscription(anObject as Subscription))
                {
                    validation = true;
                    throw new AlreadySubscriptedException("El estudiante ya esta pago esa couta.");
                }
            }
            return validation;
        }
        private bool CanIAdd(Object anObject)
        {
            SubscriptionValidator validator = new SubscriptionValidator();
            bool domainValidation = validator.IsValid(anObject);
            return domainValidation && !StudentAlreadyPayThisMonth(anObject);
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
            return GetAllSubscriptions().Count;
        }
    }
}
