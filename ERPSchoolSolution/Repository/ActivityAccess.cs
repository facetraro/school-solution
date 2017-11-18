using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;

namespace Repository
{
    public class ActivityAccess : IDBAccess
    {
        public void Add(Object anObject)
        {
            Activity newActivity = anObject as Activity;
            AddActivity(newActivity);
        }
        public void Remove(Object anObject)
        {

        }

        public void Empty()
        {

        }
        private List<ActivityPayment> GetActivityPaymentsListAttached(ContextDB context, Activity modifiedActivity)
        {
            List<ActivityPayment> listOfActivityPayments = new List<ActivityPayment>();
            foreach (ActivityPayment actualActivityPayment in modifiedActivity.ActivityPayments)
            {
                listOfActivityPayments.Add(context.ActivityPayments.Where(b => b.Id == actualActivityPayment.Id).FirstOrDefault());

            }
            return listOfActivityPayments;
        }


        private void AddActivity(Activity activity)
        {
            using (var context = new ContextDB())
            {
                try
                {
                    activity.ActivityPayments = GetActivityPaymentsListAttached(context, activity);
                    context.Activities.Add(activity);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new ActivityPersistanceException("Se ha perdido la conexion con el servidor");
                }
            }
        }
        public Activity Get(int id)
        {
            return new Activity();
        }
        public List<Activity> GetAllLazyLoading()
        {
            List<Activity> allActivities = new List<Activity>();
            try
            {
                using (var context = new ContextDB())
                {
                    allActivities = context.Activities.ToList();
                }
            }
            catch (Exception)
            {
                throw new ActivityPersistanceException("Se ha perdido la conexion con el servidor");
            }
            return allActivities;
        }
        public List<Activity> GetAll()
        {
            List<Activity> lazyLoading = GetAllLazyLoading();
            List<Activity> allActivities = new List<Activity>();
            foreach (Activity item in lazyLoading)
            {
                allActivities.Add(Get(item.Id));
            }
            return allActivities;
        }
    }
}
