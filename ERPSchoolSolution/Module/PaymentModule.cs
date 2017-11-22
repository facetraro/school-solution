using Domain;
using Exceptions;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module
{
    public class PaymentModule : ModuleClass
    {
        public PaymentModule()
        {
            this.Name = "Gestión de Pagos";
            this.Description = "Sector que permite gestionar los pagos de coutas y actividades de los Alumnos.";
        }

        public void AddSubscription(object selected, int year, int month)
        {
            SubscriptionLogic logic = new SubscriptionLogic();
            Subscription newSubscription = new Subscription();
            newSubscription.Date = new DateTime(year,month,2);
            newSubscription.Student = selected as Student;
            logic.Add(newSubscription);
        }
        public void AddNewActivityPayment(object selectedActivity, object selectedStudent)
        {
            ActivityPaymentLogic logic = new ActivityPaymentLogic();
            ActivityPayment newActivityPayment = new ActivityPayment();
            Activity activity = selectedActivity as Activity;
            Student student = selectedStudent as Student;
            newActivityPayment.Activity = activity;
            newActivityPayment.Student = student;
            logic.Add(newActivityPayment);
        }
    }
}
