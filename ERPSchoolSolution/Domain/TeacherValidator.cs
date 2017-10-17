using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TeacherValidator : IValidator
    {
        private bool IsIdValid(Teacher aTeacher)
        {
            if (!(aTeacher.Id > 0))
            {
                throw new EmptyOrNullValueException("El id debe ser mayor a 0");
            }
            return true;
        }
        private bool IsNameValid(Teacher aTeacher)
        {
            if (!(aTeacher.Name.Length > 0))
            {
                throw new EmptyOrNullValueException("El nombre ingresado es vacio");
            }
            return true;
        }
        private bool IsLastNameValid(Teacher aTeacher)
        {
            if (!(aTeacher.LastName.Length > 0))
            {
                throw new EmptyOrNullValueException("El apellido ingresado es vacio");
            }
            return true;
        }

        public bool IsValid(Object anObject)
        {
            Teacher theTeacher = anObject as Teacher;

            if ((System.Object)theTeacher == null)
            {
                throw new InvalidObjectAddIntoTeacherException("Se esperaba un objeto del tipo [Teacher]");
            }
            return (IsIdValid(theTeacher) && IsNameValid(theTeacher) && IsLastNameValid(theTeacher));
        }
    }
}