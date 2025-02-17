﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSchoolValidator
{
    public class Activity
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime Date { get; set; }
        public int Cost { get; set; }
        public List<ActivityPayment> ActivityPayments { get; set; }
        public Activity()
        {
            Id = 0;
            Name = "defaultname";
            Date = new DateTime();
            Cost = 0;
            ActivityPayments = new List<ActivityPayment>();
        }
        public override bool Equals(object anActivity)
        {
            Activity theActivity = anActivity as Activity;
            if ((System.Object)theActivity == null)
            {
                return false;
            }
            return (this.Id == theActivity.Id);
        }
        public override string ToString()
        {
            return "[" + Id + "] "+ Name + " - Costo: $" + Cost;
        }

    }
}
