using Domain;
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
           
        }
        public void Remove(object anObject)
        {
            
        }
        public Subscription Get(int id)
        {
            return new Subscription();
        }
        public List<Subscription> GetAllLazyLoading()
        {
            List<Subscription> allSubscriptions = new List<Subscription>();  
            return allSubscriptions;
        }
        public List<Subscription> GetAll()
        {
            List<Subscription> lazyLoading = GetAllLazyLoading();
            List<Subscription> allStudents = new List<Subscription>();
            foreach (Subscription item in lazyLoading)
            {
                allStudents.Add(Get(item.Id));
            }
            return allStudents;
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
