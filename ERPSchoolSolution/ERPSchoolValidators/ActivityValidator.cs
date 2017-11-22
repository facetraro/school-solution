using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions;
namespace ERPSchoolValidator
{
    public class ActivityValidator : IValidator
    {
        private bool IsIdValid(Activity anActivity)
        {
            bool idValidation = true;
            if (!(anActivity.Id > 0))
            {
                idValidation = false;
            }
            return idValidation;
        }
        private bool IsNameValid(Activity anActivity)
        {
            bool nameValidation = true;
            if (!(anActivity.Name.Length > 0))
            {
                nameValidation = false;
            }
            return nameValidation;
        }
        private bool IsCostValid(Activity anActivity)
        {
            bool costValidation = true;
            if (!(anActivity.Cost > 0))
            {
                costValidation = false;
            }
            return costValidation;
        }
        public bool IsValid(Object anObject)
        {
            Activity theActivity = anObject as Activity;
            if ((System.Object)theActivity == null)
            {
                throw new InvalidObjectAddIntoTeacherException("Se esperaba un objeto del tipo [Activity]");
            }
            bool ActivityValidationId = IsIdValid(theActivity);
            if (!ActivityValidationId)
            {
                throw new EmptyOrNullValueException("El id ingresado no es valido");
            }
            bool ActivityValidationName = IsNameValid(theActivity);
            if (!ActivityValidationName)
            {
                throw new EmptyOrNullValueException("El nombre ingresado no es valido");
            }
            bool ActivityValidationCost = IsCostValid(theActivity);
            if (!ActivityValidationCost)
            {
                throw new EmptyOrNullValueException("El costo ingresado no es valido");
            }
            return ActivityValidationId && ActivityValidationName && ActivityValidationCost;
        }
    }
}
