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
                }
            }
            return validation;
        }
        private DateTime GetFistDateToCheck(Subscription subscription)
        {
            DateTime date = subscription.Date;
            DateTime dateToCheck = new DateTime(date.Year, date.Month, 1);
            dateToCheck = dateToCheck.AddMonths(-1);
            return dateToCheck;
        }
        private Subscription GetFirstSubscriptionToCheck(Subscription subscription)
        {
            Subscription checkSubscription = new Subscription();
            checkSubscription.Date = GetFistDateToCheck(subscription);
            checkSubscription.Student = subscription.Student;
            return checkSubscription;
        }
        private bool IsStudentUpToDate(Object anObject)
        {
            bool validation = true;
            Subscription subscription = anObject as Subscription;
            Subscription checkSubscription = GetFirstSubscriptionToCheck(subscription);
            SubscriptionValidator validator = new SubscriptionValidator();
            while (validator.IsDateValid(checkSubscription))
            {
                if (!StudentAlreadyPayThisMonth(checkSubscription))
                {
                    validation = false;
                    String message = "El estudiante debe coutas anteriores, la couta " + checkSubscription.Date.Month + "/" + checkSubscription.Date.Year + " no se ha pagado.";
                    throw new StudentNotUpToDateException(message);
                }
                checkSubscription.Date = checkSubscription.Date.AddMonths(-1);
            }
            return validation;
        }
        private bool CanIAdd(Object anObject)
        {
            SubscriptionValidator validator = new SubscriptionValidator();
            bool domainValidation = validator.IsValid(anObject);
            bool newSubscription = ! StudentAlreadyPayThisMonth(anObject);
            bool studentUpToDate = false;
            if (!newSubscription)
            {
                throw new AlreadySubscriptedException("El estudiante ya esta pago esa couta.");
            }
            else
            {
                studentUpToDate = IsStudentUpToDate(anObject);
            }
            return domainValidation && newSubscription && studentUpToDate;
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
