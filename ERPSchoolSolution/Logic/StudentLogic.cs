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
        Student Clone(Student aStudent)
        {
            Student clone = new Student();
            clone.Ci = aStudent.Ci;
            clone.Coordinates = aStudent.Coordinates;
            clone.LastName = aStudent.LastName;
            clone.Name = aStudent.Name;
            clone.StudentNumber = aStudent.StudentNumber;
            clone.Subjects = aStudent.Subjects;
            return clone;
        }
        private void Insert(Student toAdd)
        {
            StudentAccess context = new StudentAccess();
            context.Add(toAdd);
        }
        public void Add(Object anObject)
        {
            if (CanIAdd(anObject))
            {
                Student toAdd = anObject as Student;
                Insert(toAdd);
            }
        }
        private void Delete(Student anObject)
        {
            StudentAccess context = new StudentAccess();
            context.Remove(anObject);
        }
        public void Remove(Object anObject)
        {
            Student toDelete = anObject as Student;
            Delete(toDelete);
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
                StudentAccess context = new StudentAccess();
                Student newStudent = anotherObject as Student;
                context.Modify(newStudent);
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
            StudentAccess context = new StudentAccess();
            context.Empty();
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
            List<Student> list = GetAllStudents();
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
            return GetAllStudents().Count;
        }
        public bool IsEmpty()
        {
            return Length() == 0;
        }
        public List<Student> GetAllStudents()
        {
            StudentAccess context = new StudentAccess();
            return context.GetAll();
        }
    }
}
