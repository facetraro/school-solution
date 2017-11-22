using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSchoolValidator
{
    public class StudentValidator : IValidator
    {
        private static int min_ci = 999999;
        private bool IsCiValid(Student aStudent)
        {
            if(!(aStudent.Ci > min_ci))
            {
                throw new InvalidCiException("La Cedula ingresada no es valida");
            }
            return true;
        }
        private bool IsNameValid(Student aStudent)
        {
            if(!(aStudent.Name.Length > 0))
            {
                throw new EmptyOrNullValueException("El nombre ingresado no es valido");
            }
            return true;
        }
        private bool IsLastNameValid(Student aStudent)
        {
            if (!(aStudent.LastName.Length > 0))
            {
                throw new EmptyOrNullValueException("El apellido ingresado no es valido");
            }
            return true;
        }
        private bool HasSubjects(Student aStudent)
        {
            if (aStudent.Subjects.Count == 0)
            {
                throw new EmptyOrNullValueException("El nuevo usuario debe tener materias");
            }
            return true;
        }
        public bool IsValid(object anObject)
        {
            Student theStudent = anObject as Student;
            if ((System.Object)theStudent == null)
            {
                throw new InvalidObjectAddIntoStudentException("Se esperaba un objeto del tipo [Subject]");
            }
            bool ciValidation = IsCiValid(theStudent);
            bool nameValidation = IsNameValid(theStudent);
            bool lastNameValidation = IsLastNameValid(theStudent);
            bool subjectsValidation = HasSubjects(theStudent);
            bool validation = ciValidation && nameValidation && lastNameValidation && subjectsValidation;
            return validation;
        }
    }
}
