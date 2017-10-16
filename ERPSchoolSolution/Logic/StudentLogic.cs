using Domain;
using Exceptions;
using Repository;
using System;
using System.Collections.Generic;

namespace Logic
{
    public class StudentLogic : IAddRemoveModify
    {
        private bool IsNewUser(Object anObject)
        {
            bool newStudent = !Exists(anObject);
            if (!newStudent)
            {
                Singleton theRepository = Singleton.Instance;
                if (IsCiAlreadyUsed(anObject))
                {
                    throw new InvalidCiException("La CI ya esta ingresada en el sistema");
                }
                if (theRepository.Students.Contains((Student)anObject))
                {
                    throw new StudentAlreadyExistsException("El numero estudiante ya esta ingresado en el sistema");
                }
            }
            return newStudent;
        }
        private bool CanIAdd(Object anObject)
        {
            StudentValidator validator = new StudentValidator();
            bool domainValidations = validator.IsValid(anObject);
            bool validation = domainValidations && IsNewUser(anObject);
            return validation;
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
        private bool IsTheSameIdWithNewNonExistenCi(Object anObject, Object anotherObject)
        {
            bool sameId = anObject.Equals(anotherObject);
            Student aStudent = anObject as Student;
            Student anotherStudent = anotherObject as Student;
            bool sameCI = aStudent.Ci.Equals(anotherStudent.Ci);
            if (sameId && (sameCI || !IsCiAlreadyUsed(anotherObject)))
            {
                return true;
            }
            if (!sameId)
            {
                throw new StudentAlreadyExistsException("El numero estudiante ya esta ingresado en el sistema");
            }
            throw new InvalidCiException("La Ci ingresada ya esta registarada en el sistema");
            return false;
        }
        private bool ModifyValidation(Object anObject, Object anotherObject)
        {
            StudentValidator validator = new StudentValidator();
            bool domainValidation = validator.IsValid(anotherObject);
            bool nonExists = !Exists(anotherObject);
            bool sameId = anObject.Equals(anotherObject);
            Student aStudent = anObject as Student;
            Student anotherStudent = anotherObject as Student;
            bool sameCI = aStudent.Ci.Equals(anotherStudent.Ci);
            return domainValidation && (nonExists || IsTheSameIdWithNewNonExistenCi(anObject, anotherObject));
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
        private int GetBiggestIdStudent(List<Student> list)
        {
            int biggestSoFar = 0;
            foreach (Student item in list)
            {
                if (item.Id > biggestSoFar) biggestSoFar = item.Id;
            }
            return biggestSoFar;
        }
        public int GetNextIdFree()
        {
            List<Student> list = GetAllStudents();
            return (GetBiggestIdStudent(list) + 1);
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
            bool ciValidation = IsCiAlreadyUsed(anObject);
            bool studentNumberValidation = theRepository.Students.Contains(lookUp);
            bool validation = ciValidation || studentNumberValidation;
            return validation;
        }
        public bool IsCiAlreadyUsed(Object anObject)
        {
            Singleton theRepository = Singleton.Instance;
            Student toAdd = anObject as Student;
            List<Student> list = theRepository.Students;
            foreach (Student item in list)
            {
                if (item.Ci.Equals(toAdd.Ci))
                {
                    return true;
                }
            }
            return false;
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
