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
        private void Delete(Activity anObject)
        {
            ActivityAccess context = new ActivityAccess();
            context.Remove(anObject);
        }
        public void Remove(Object anObject)
        {
            Activity toDelete = anObject as Activity;
            Delete(toDelete);
        }
        private bool ModifyValidation(Object anObject, Object anotherObject)
        {
            ActivityValidator validator = new ActivityValidator();
            bool domainValidation = validator.IsValid(anotherObject);
            bool sameId = anObject.Equals(anotherObject);
            return domainValidation && sameId;
        }
        private bool CanIModify(Object anObject, Object anotherObject)
        {
            return (Exists(anObject) && ModifyValidation(anObject, anotherObject));
        }
        public void Modify(Object oldObject, Object newObject)
        {
            if (CanIModify(oldObject,newObject))
            {
                ActivityAccess context = new ActivityAccess();
                Activity newActivity = newObject as Activity;
                context.Modify(newActivity);
            }
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
