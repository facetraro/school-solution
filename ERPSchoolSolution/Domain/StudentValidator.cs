﻿using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class StudentValidator : IValidator
    {
        private static int MIN_CI = 9999999;
        private bool IsCiValid(Student aStudent)
        {
            if(!(aStudent.Ci >= MIN_CI))
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
            return IsCiValid(theStudent) && IsNameValid(theStudent) && IsLastNameValid(theStudent) && HasSubjects(theStudent);
        }
    }
}
