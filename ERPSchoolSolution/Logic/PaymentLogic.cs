using ERPSchoolValidator;
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
        public List<Payment> AddSubscriptionsToList(List<Payment> allPayments, List<ActivityPayment> paymentsToAdd)
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
            ActivityPaymentLogic ActivityPaymentLogic = new ActivityPaymentLogic();
            List<Subscription> allSubscriptions = subscriptionLogic.GetAllSubscriptions();
            List<Payment> allPayments = AddSubscriptionsToList(new List<Payment>(), allSubscriptions);
            List<ActivityPayment> allActivityPayment = ActivityPaymentLogic.GetAllActivityPayments();
            allPayments = AddSubscriptionsToList(allPayments, allActivityPayment);
            return allPayments;
        }
        public List<Payment> GetAllPaymentsByStudent(Student student)
        {
            List<Payment> allPayments = GetAllPayments();
            List<Payment> paymentsByStudent = new List<Payment>();
            foreach (Payment item in allPayments)
            {
                if (item.Student.Equals(student))
                {
                    paymentsByStudent.Add(item);
                }
            }
            return paymentsByStudent;
        }
    }
}
