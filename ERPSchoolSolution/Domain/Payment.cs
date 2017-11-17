using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Payment
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public override bool Equals(object anotherObject)
        {
            Payment anotherPayment = anotherObject as Payment;
            if (anotherPayment == null)
            {
                return false;
            }
            return (this.Id == anotherPayment.Id);
        }
    }
}
