using Domain;
using Exceptions;
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
        public void Insert(Teacher toAdd)
        {
            TeacherAccess context = new TeacherAccess();
            context.Add(toAdd);
        }
        private bool CanIAdd(Object anObject)
        {
            TeacherValidator validator = new TeacherValidator();
            bool domainValidations = validator.IsValid(anObject);
            bool validation = domainValidations;
            return validation;
        }
        public void Add(Object anObject)
        {
            if (CanIAdd(anObject))
            {
                Teacher aTeacher = anObject as Teacher;
                Insert(aTeacher);
            }
        }

        public bool Exists(Object anObject)
        {
            TeacherAccess context = new TeacherAccess();
            Teacher lookUp = anObject as Teacher;
            bool exists = GetAllTeachers().Contains(lookUp);
            return exists;
        }
        private void Delete(Teacher anObject)
        {
            TeacherAccess context = new TeacherAccess();
            context.Remove(anObject);
        }
        public void Remove(Object anObject)
        {
            Teacher toDelete = anObject as Teacher;
            Delete(toDelete);
        }
        private bool ModifyValidation(Object anObject, Object anotherObject)
        {
            TeacherValidator validator = new TeacherValidator();
            bool domainValidation = validator.IsValid(anotherObject);
            bool nonExists = !Exists(anotherObject);
            bool sameId = anObject.Equals(anotherObject);
            Teacher aTeacher = anObject as Teacher;
            Teacher anotherTeacher = anotherObject as Teacher;
            if (!(nonExists || sameId))
            {
                throw new TeacherAlreadyExistsException("El numero profesor ya esta ingresado en el sistema");
            }

            return domainValidation && (nonExists || sameId);
        }
        private bool CanIModify(Object anObject, Object anotherObject)
        {
            return (this.Exists(anObject) && ModifyValidation(anObject, anotherObject));
        }
        public void Modify(Object anObject, Object anotherObject)
        {
            if (CanIModify(anObject, anotherObject))
            {
                TeacherAccess context = new TeacherAccess();
                Teacher newTeacher = anotherObject as Teacher;
                context.Modify(newTeacher);
            }
        }
        public int Length()
        {
            return GetAllTeachers().Count;
        }
        public void Empty()
        {
            Singleton theRepository = Singleton.Instance;
            theRepository.Teachers = new List<Teacher>();
        }
        public List<Teacher> GetAllTeachers()
        {
            TeacherAccess context = new TeacherAccess();
            return context.GetAll();
        }

        private int GetBiggestIdTeacher(List<Teacher> list)
        {
            int biggestSoFar = 0;
            foreach (Teacher item in list)
            {
                if (item.Id > biggestSoFar) biggestSoFar = item.Id;
            }
            return biggestSoFar;
        }
        public int GetNextIdFree()
        {
            List<Teacher> list = GetAllTeachers();
            return (GetBiggestIdTeacher(list) + 1);
        }
    }
}
