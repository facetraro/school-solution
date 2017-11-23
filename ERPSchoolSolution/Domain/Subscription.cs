using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSchoolValidator
{
    public class Subscription : Payment
    {
        private static int DefaultAmount = 500;
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public Subscription()
        {
            this.Id = 1;
            this.Student = new Student();
            this.Date = new DateTime();
            this.Amount = DefaultAmount;
        }
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
            int comparationResult = this.Date.CompareTo(anotherDate);
            if (comparationResult > 0)
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
        public override string ToString()
        {
            return ("Couta: " + this.Date.Month+"/"+this.Date.Year+" $"+this.Amount);
        }
    }
}
