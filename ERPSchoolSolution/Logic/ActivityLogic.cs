using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repository;

namespace Logic
{
    public class ActivityLogic : IAddRemoveModify
    {
        public void Add(Object anObject)
        {
            Activity toAdd = anObject as Activity;
            ActivityAccess context = new ActivityAccess();
            context.Add(toAdd);
        }

        public void Remove(Object anObject)
        {

        }
        public void Modify(Object oldObject, Object newObject)
        {

        }
        public bool Exists(Object anObject)
        {
            Activity lookUp = anObject as Activity;
            ActivityAccess context = new ActivityAccess();
            return context.GetAll().Contains(lookUp);
        }
        public List<Activity> GetAllActivities()
        {
            ActivityAccess context = new ActivityAccess();
            return context.GetAll();
        }
    }
}
