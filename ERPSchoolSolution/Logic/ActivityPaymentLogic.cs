using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERPSchoolValidator;
using Repository;

namespace Logic
{
    public class ActivityPaymentLogic : IAdd
    {
        public void Add(Object anObject)
        {
            ActivityPayment anActivityPayment = anObject as ActivityPayment;
            Insert(anActivityPayment);
        }
        private void Insert(ActivityPayment toAdd)
        {
            ActivityPaymentAccess context = new ActivityPaymentAccess();
            context.Add(toAdd);
        }
        public bool Exists(Object anObject)
        {
            ActivityPaymentAccess context = new ActivityPaymentAccess();
            ActivityPayment lookUp = anObject as ActivityPayment;
            bool exists = GetAllActivityPayments().Contains(lookUp);
            return exists;
        }
        public List<ActivityPayment> GetAllActivityPayments()
        {
            ActivityPaymentAccess context = new ActivityPaymentAccess();
            return context.GetAll();
        }
    }
}
