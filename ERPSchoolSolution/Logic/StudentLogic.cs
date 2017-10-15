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
        private bool ModifyValidation(Object anObject, Object anotherObject)
        {
            StudentValidator validator = new StudentValidator();
            bool domainValidation = validator.IsValid(anotherObject);
            bool nonExists = !Exists(anotherObject);
            bool sameId = anObject.Equals(anotherObject);
            return domainValidation && (nonExists || sameId);
        }
        private bool CanIModify(Object anObject, Object anotherObject)
        {
            return (Exists(anObject) && ModifyValidation(anObject, anotherObject));
        }
        public void Modify(Object anObject, Object anotherObject)
        {
            if (CanIModify(anObject, anotherObject))
            {
                Remove(anObject);
                Add(anotherObject);
            }
        }
      
        public int GetNextIdFree()
        {
            List<Student> list = GetAllStudents();
            int biggestSoFar = 0;
            foreach (Student item in list)
            {
                if (item.Id > biggestSoFar) biggestSoFar = item.Id;
            }
            return (biggestSoFar+1);
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

        public List<Student> GetAllStudents()
        {
            Singleton theRepository = Singleton.Instance;
            return theRepository.Students;
        }
    }
}
