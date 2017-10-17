using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SubjectValidator : IValidator
    {
        private bool IsNameValid(Subject theSubject)
        {
            if (theSubject.Name != "")
            {
                return true;
            }
            throw new EmptyOrNullValueException("El nombre ingresado es vacio");
        }
        public bool IsCodeValid(Subject theSubject)
        {
            if (theSubject.Code != null && theSubject.Code != "")
            {
                return true;
            }
            throw new EmptyOrNullValueException("El codigo ingresado es vacio");
        }
        public bool IsValid(Object anObject)
        {
            Subject theSubject = anObject as Subject;
            if ((System.Object)theSubject == null)
            {
                throw new InvalidObjectAddIntoSubjectsException("Se esperaba un objeto del tipo [Subject]");
            }
            bool codeValidation = IsCodeValid(theSubject);
            bool nameValidation = IsNameValid(theSubject);
            bool validation = codeValidation && nameValidation;
            return validation;
        }
    }
}