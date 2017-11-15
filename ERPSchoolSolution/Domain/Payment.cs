using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Payment
    {
        public int Id;
        public Student Student;
        public int Amount;
        public override bool Equals(object aPerson)
        {
            return true;
        }
    }
}
