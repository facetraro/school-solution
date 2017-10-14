using Domain;
using Repository;
using System;
using System.Collections.Generic;

namespace Logic
{
    public class StudentLogic : IAddRemoveModify
    {
        private bool CanIAdd(Object anObject)
        {
            StudentValidator validator = new StudentValidator();
            return validator.IsValid(anObject) && !Exists(anObject);
        }
        private void Insert(Student toAdd)
        {
            Singleton theRepository = Singleton.Instance;
            theRepository.Students.Add(toAdd);
        }
        public void Add(Object anObject)
        {
            if (CanIAdd(anObject))
            {
                Student toAdd = anObject as Student;
                Insert(toAdd);
            }
        }
        public void Remove(Object anObject)
        {
            Student toDelete = anObject as Student;
            Singleton theRepository = Singleton.Instance;
            theRepository.Students.Remove(toDelete);
        }
        private bool CanIModify(Object anObject, Object anotherObject)
        {
            return (Exists(anObject) && CanIAdd(anotherObject));
        }
        public void Modify(Object anObject, Object anotherObject)
        {
            if (CanIModify(anObject, anotherObject))
            {
                Remove(anObject);
                Add(anotherObject);
            }
        }
        public void Empty()
        {
            Singleton theRepository = Singleton.Instance;
            theRepository.Students = new List<Student>();
        }
        public bool Exists(Object anObject)
        {
            Singleton theRepository = Singleton.Instance;
            Student lookUp = anObject as Student;
            return theRepository.Students.Contains(lookUp);
        }
        public int Length()
        {
            Singleton theRepository = Singleton.Instance;
            return theRepository.Students.Count;
        }
        public bool IsEmpty()
        { 
            return Length() == 0;
        }
    }
}
