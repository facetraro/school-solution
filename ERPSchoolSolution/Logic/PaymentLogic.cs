using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class PaymentLogic
    {
        public List<Payment> AddSubscriptionsToList(List<Payment> allPayments, List<Subscription> paymentsToAdd)
        {
            foreach (Payment item in paymentsToAdd)
            {
                allPayments.Add(item);
            }
            return allPayments;
        }

        public List<Payment> GetAllPayments()
        {
            SubscriptionLogic subscriptionLogic = new SubscriptionLogic();
            List<Subscription> allSubscriptions = subscriptionLogic.GetAllSubscriptions();
            List<Payment> allPayments = AddSubscriptionsToList(new List<Payment>(), allSubscriptions);           
            return allPayments;
        }
    }
}
