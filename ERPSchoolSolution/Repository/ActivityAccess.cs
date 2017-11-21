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
    public class ActivityAccess : ARMEAccess
    {
        public void Add(Object anObject)
        {
            Activity newActivity = anObject as Activity;
            AddActivity(newActivity);
        }
        public void Remove(Object anObject)
        {
            Activity activity = anObject as Activity;
            RemoveActivity(activity);
        }
        private void RemoveActivity(Activity activity)
        {
            try
            {
                using (var context = new ContextDB())
                {
                    context.Activities.Attach(activity);
                    context.Activities.Remove(activity);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new ActivityPersistanceException("Se ha perdido la conexion con el servidor");
            }
        }
        public void Empty()
        {
            try
            {
                using (var context = new ContextDB())
                {
                    List<Activity> activities = context.Activities.ToList();
                    foreach (Activity actual in activities)
                    {
                        Activity toDelete = context.Activities.Find(actual.Id);
                        context.Activities.Remove(toDelete);
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new ActivityPersistanceException("Se ha perdido la conexion con el servidor");
            }
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
            try
            {
                using (var context = new ContextDB())
                {
                    Activity activityToFind = context.Activities.Find(id);
                    context.Activities.Include(d => d.ActivityPayments).ToList();
                    return activityToFind;
                }
            }
            catch (Exception)
            {
                throw new ActivityPersistanceException("Se ha perdido la conexion con el servidor");
            }
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

        public void Modify(Object anObject)
        {
            Activity activity = anObject as Activity;
            ModifyActivity(activity);
        }
        private void ModifyActivity(Activity modifiedActivity)
        {
            try
            {
                using (var context = new ContextDB())
                {
                    Activity oldActivity = Get(modifiedActivity.Id);
                    context.Activities.Attach(oldActivity);
                    oldActivity.Name = modifiedActivity.Name;
                    oldActivity.Cost = modifiedActivity.Cost;
                    oldActivity.Date = modifiedActivity.Date;
                    context.Entry(oldActivity).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new ActivityPersistanceException("Se ha perdido la conexion con el servidor");
            }
        }
    }
}
