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
        public bool IsBefore(DateTime anotherDate)
        {
            int comparationResult = this.Date.CompareTo(anotherDate);
            if (comparationResult < 0)
            {
                return true;
            }
            return false;
        }
        public bool IsAfter(DateTime anotherDate)
        {
            if (this.Date.CompareTo(anotherDate) > 0)
            {
                return true;
            }
            return false;
        }
        public bool IsTheSameYear(DateTime anotherDate)
        {
            bool yearValidation = this.Date.Year == anotherDate.Year;
            return yearValidation;
        }
        private bool IsTheSameMonth(DateTime anotherDate)
        {
            bool monthValidation = this.Date.Month == anotherDate.Month;
            return monthValidation;
        }
        private bool IsTheSameDate(DateTime anotherDate)
        {
            bool yearValidation = IsTheSameYear(anotherDate);
            bool monthValidation = IsTheSameMonth(anotherDate);
            return yearValidation && monthValidation;
        }
        public bool IsTheSameSubscription(Subscription anotherPayment)
        {
            bool dateValidation = IsTheSameDate(anotherPayment.Date);
            bool studentValidation = this.Student.Equals(anotherPayment.Student);
            bool amountValidation = this.Amount == anotherPayment.Amount;
            bool allValidation = studentValidation && dateValidation && amountValidation;
            return allValidation;
        }
    }
}
