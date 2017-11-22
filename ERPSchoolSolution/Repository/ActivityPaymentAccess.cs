using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;
using System.Data.Entity;


namespace Repository
{
    public class ActivityPaymentAccess : IDBAccess
    {
        public void Add(Object anObject)
        {
            ActivityPayment activityPayment = anObject as ActivityPayment;
            AddActivityPayment(activityPayment);
        }
        private void AddActivityPayment(ActivityPayment activityPayment)
        {
            using (var context = new ContextDB())
            {
                try
                {
                    context.Students.Attach(activityPayment.Student);
                    context.Activities.Add(activityPayment.Activity);
                    context.ActivityPayments.Add(activityPayment);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new ActivityPaymentPersistanceException("Se ha perdido la conexion con el servidor");
                }
            }
        }
        public void Remove(Object anObject)
        {

        }
        public void Empty()
        {

        }
        public ActivityPayment Get(int id)
        {
            try
            {
                using (var context = new ContextDB())
                {
                    ActivityPayment activityPaymentToFind = context.ActivityPayments.Find(id);
                    context.ActivityPayments.Include(d => d.Student).ToList();
                    context.ActivityPayments.Include(d => d.Activity).ToList();
                    return activityPaymentToFind;
                }
            }
            catch (Exception)
            {
                throw new ActivityPaymentPersistanceException("Se ha perdido la conexion con el servidor");
            }
        }
        public List<ActivityPayment> GetAllLazyLoading()
        {
            List<ActivityPayment> allActivityPayments = new List<ActivityPayment>();
            try
            {
                using (var context = new ContextDB())
                {
                    allActivityPayments = context.ActivityPayments.ToList();
                }
            }
            catch (Exception)
            {
                throw new ActivityPaymentPersistanceException("Se ha perdido la conexion con el servidor");
            }
            return allActivityPayments;
        }
        public List<ActivityPayment> GetAll()
        {
            List<ActivityPayment> lazyLoading = GetAllLazyLoading();
            List<ActivityPayment> allActivityPayments = new List<ActivityPayment>();
            foreach (ActivityPayment item in lazyLoading)
            {
                allActivityPayments.Add(Get(item.Id));
            }
            return allActivityPayments;
        }
    }
}
