using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Activity
    {
        public int Id { get; set; }

        public override bool Equals(object aPerson)
        {
            return true;
        }
    }
}
