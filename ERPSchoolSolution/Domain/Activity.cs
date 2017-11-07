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
        public String Name { get; set; }
        public DateTime Date { get; set; }
        public int Cost { get; set; }

        public override bool Equals(object anActivity)
        {
            Activity theActivity = anActivity as Activity;

            return (this.Id == theActivity.Id);
        }
    }
}
