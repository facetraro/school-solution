using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class TeacherLogic : IAddRemoveModify
    {
        public void Insert(Object anObject)
        {
            Singleton theRepository = Singleton.Instance;
            Teacher toAdd = anObject as Teacher;
            theRepository.Teachers.Add(toAdd);
        }
        public bool CanIAdd(Object anObject)
        {
            TeacherValidator validator = new TeacherValidator();
            if (validator.IsValid(anObject))
            {
                return !this.Exists(anObject);
            }
            return false;
        }
        public void Add(Object anObject)
        {
            if (CanIAdd(anObject))
            {
                Insert(anObject);
            }
        }
        public bool Exists(Object anObject)
        {
            Singleton theRepository = Singleton.Instance;
            Teacher lookUp = anObject as Teacher;
            return theRepository.Teachers.Contains(lookUp);
        }
        public void Remove(Object anObject)
        {
            Singleton theRepository = Singleton.Instance;
            Teacher toRemove = anObject as Teacher;
            theRepository.Teachers.Remove(toRemove);
        }
        public void Modify(Object anObject, Object anotherObject)
        {
            if (this.Exists(anObject))
            {
                Remove(anObject);
                Add(anotherObject);
            }  
        }
        public int Length()
        {
            Singleton theRepository = Singleton.Instance;
            return theRepository.Teachers.Count;
        }
        public void Empty()
        {
            Singleton theRepository = Singleton.Instance;
            theRepository.Teachers = new List<Teacher>();
        }
    }
}
