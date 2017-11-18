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
        private bool IsDateValid(Subscription theSubscription)
        {
            if (theSubscription.IsAfter(new DateTime(2017, 11, 1, 0, 0, 0)))
            {
                return true;
            }
            throw new EmptyOrNullValueException("La fecha de pago no puede ser antes de Noviembre del 2017");
        }
        public bool IsValid(Object anObject)
        {
            Subscription theSubscription = anObject as Subscription;
            if ((System.Object)theSubscription == null)
            {
                throw new InvalidObjectAddIntoSubscriptionException("Se esperaba un objeto del tipo [Subscription]");
            }
            bool dateValidation = IsDateValid(theSubscription);
            return dateValidation;
        }
    }
}