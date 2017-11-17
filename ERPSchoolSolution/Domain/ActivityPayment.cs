﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ActivityPayment : Payment
    {
        public Activity Activity;

        public bool IsTheSameActivityPayment(ActivityPayment anActivityPayment) {
            bool sameStudent = this.Student.Equals(anActivityPayment.Student);
            bool sameActivity = this.Activity.Equals(anActivityPayment.Activity);
            return sameStudent && sameActivity;
        }

    }
}
