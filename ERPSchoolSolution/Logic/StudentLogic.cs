using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void Modify(Object anObject, Object anotherObject)
        {
            Remove(anObject);
            Add(anotherObject);
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
    }
}
