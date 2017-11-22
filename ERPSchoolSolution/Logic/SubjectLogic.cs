using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERPSchoolValidator;
using Repository;
using Exceptions;

namespace Logic
{
    public class SubjectLogic
    {
        public bool IsEmpty()
        {
            return this.Length() == 0;
        }
        private string GenerateNewCode()
        {
            string posibleChars = "0123456789abcdefghijlkmnopqrstuvwxyz";
            string code = "";
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                code = code + posibleChars.ElementAt(random.Next(1, 34));
            }
            return code;
        }
        public List<Subject> GetAllSubjects()
        {
            SubjectAccess context = new SubjectAccess();
            return context.GetAll();
        }
        private bool CanIAdd(Object anObject)
        {
            SubjectValidator validator = new SubjectValidator();
            bool nonExists = !Exists(anObject);
            if (!nonExists)
            {
                throw new SubjectAlreadyExistsException("La materia ya esta ingresada en el sistema.");
            }
            return validator.IsValid(anObject) && nonExists;
        }
        public void AddNewSubject(string name)
        {
            Subject newSubject = new Subject();
            newSubject.Code = GenerateNewCode();
            newSubject.Name = name;
            this.Add(newSubject);
        }
        public void Insert(Subject aSubject)
        {
            SubjectAccess context = new SubjectAccess();
            context.Add(aSubject);
        }
        public void Add(Object anObject)
        {
            if (CanIAdd(anObject))
            {
                {
                    Subject newSubject = anObject as Subject;
                    Insert(newSubject);
                }
            }
        }
        public bool Exists(Object anObject)
        {
            Subject newSubject = anObject as Subject;
            return GetAllSubjects().Contains(newSubject);
        }
        public void Remove(Object anObject)
        {
            Subject toDelete = anObject as Subject;
            SubjectAccess context = new SubjectAccess();
            context.Remove(toDelete);
        }
        private bool ModifyValidation(Object oldObject, Object anObject)
        {
            bool sameCode = anObject.Equals(oldObject);
            bool nonExists = !Exists(anObject);
            if (!(nonExists || sameCode))
            {
                throw new SubjectAlreadyExistsException("La materia ya esta ingresada en el sistema.");
            }
            return (nonExists || sameCode);
        }
        private bool CanIModifySubject(Object anObject, Object oldObject)
        {
            SubjectValidator validator = new SubjectValidator();
            return (validator.IsValid(anObject) && ModifyValidation(oldObject, anObject));
        }
        private bool CanIModify(Object oldObject, Object newObject)
        {
            return Exists(oldObject) && CanIModifySubject(newObject, oldObject);
        }
        public void Modify(Object oldObject, Object newObject)
        {
            if (CanIModify(oldObject, newObject))
            {
                SubjectAccess context = new SubjectAccess();
                Subject newSubject = newObject as Subject;
                context.Modify(newSubject);
            }
        }
        public int Length()
        {
            return GetAllSubjects().Count;
        }
        public void Empty()
        {
            SubjectAccess context = new SubjectAccess();
            context.Empty();
        }
    }
}
