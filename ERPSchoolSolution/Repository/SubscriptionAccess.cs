using ERPSchoolValidator;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SubscriptionAccess : IDBAccess
    {
        public void Add(object anObject)
        {
            Subscription subscription = anObject as Subscription;
            AddSubscription(subscription);
        }
        private void AddSubscription(Subscription subscription)
        {
            using (var context = new ContextDB())
            {
                try
                {
                    context.Students.Attach(subscription.Student);
                    context.Subscriptions.Add(subscription);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new SubscriptionPersistanceException("Se ha perdido la conexion con el servidor");
                }
            }
        }
        public void Remove(object anObject)
        {
            Subscription subscription = anObject as Subscription;
            RemoveSubscription(subscription);
        }
        private void RemoveSubscription(Subscription subscription)
        {
            try
            {
                using (var context = new ContextDB())
                {
                    context.Subscriptions.Attach(subscription);
                    context.Subscriptions.Remove(subscription);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new SubscriptionPersistanceException("Se ha perdido la conexion con el servidor");
            }
        }
        public Subscription Get(int id)
        {
            try
            {
                using (var context = new ContextDB())
                {
                    Subscription subscriptionToFind = context.Subscriptions.Find(id);
                    context.Subscriptions.Include(d => d.Student).ToList();
                    return subscriptionToFind;
                }
            }
            catch (Exception)
            {
                throw new SubscriptionPersistanceException("Se ha perdido la conexion con el servidor");
            }
        }
        public List<Subscription> GetAllLazyLoading()
        {
            List<Subscription> allSubscriptions = new List<Subscription>();
            try
            {
                using (var context = new ContextDB())
                {
                    allSubscriptions = context.Subscriptions.ToList();
                }
            }
            catch (Exception)
            {
                throw new SubscriptionPersistanceException("Se ha perdido la conexion con el servidor");
            }
            return allSubscriptions;
        }
        public List<Subscription> GetAll()
        {
            List<Subscription> lazyLoading = GetAllLazyLoading();
            List<Subscription> allSubcriptions = new List<Subscription>();
            foreach (Subscription item in lazyLoading)
            {
                allSubcriptions.Add(Get(item.Id));
            }
            return allSubcriptions;
        }
        public void Empty()
        {
            try
            {
                using (var context = new ContextDB())
                {
                    List<Subscription> students = context.Subscriptions.ToList();
                    foreach (Subscription actual in students)
                    {
                        Subscription toDelete = context.Subscriptions.Find(actual.Id);
                        context.Subscriptions.Remove(toDelete);
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new SubscriptionPersistanceException("Se ha perdido la conexion con el servidor");
            }
        }
    }
}
