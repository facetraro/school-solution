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
