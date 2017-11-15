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

        private bool IsTheSameDate(DateTime anotherDate)
        {
            bool yearValidation = this.Date.Year == anotherDate.Year;
            bool monthValidation = this.Date.Month == anotherDate.Month;
            return yearValidation && monthValidation;
        }
        public bool IsTheSameSubscription(Subscription anotherPayment)
        {
            bool dateValidation = IsTheSameDate(anotherPayment.Date);
            bool studentValidation = this.Student.Equals(anotherPayment.Student);
            bool amountValidation = this.Amount == anotherPayment.Amount;
            bool validation = studentValidation && dateValidation && amountValidation;
            return validation;
        }
    }
}
