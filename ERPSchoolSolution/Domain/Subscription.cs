using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Subscription : Payment
    {
        public DateTime Date;

        public bool IsTheSameSubscription(Subscription anotherPayment)
        {
            return this.Student.Equals(anotherPayment.Student);
        }
    }
}
