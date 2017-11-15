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
        public int Amount;

        public bool IsTheSameSubscription(Subscription anotherPayment)
        {
            bool yearValidation = this.Date.Year == anotherPayment.Date.Year;
            bool studentValidation = this.Student.Equals(anotherPayment.Student);
            return studentValidation && yearValidation && this.Date.Month == anotherPayment.Date.Month;
        }
    }
}
