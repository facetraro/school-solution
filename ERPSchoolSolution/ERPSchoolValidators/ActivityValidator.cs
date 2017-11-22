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
            if (!(anActivity.Id > 0))
            {
                throw new EmptyOrNullValueException("El id debe ser mayor a 0");
            }
            return true;
        }
        private bool IsNameValid(Activity anActivity)
        {
            if (!(anActivity.Name.Length > 0))
            {
                throw new EmptyOrNullValueException("El nombre ingresado no es valido");
            }
            return true;
        }
        private bool IsCostValid(Activity anActivity)
        {
            if (!(anActivity.Cost > 0))
            {
                throw new EmptyOrNullValueException("El costo ingresado no es valido");
            }
            return true;
        }
        public bool IsValid(Object anObject)
        {
            Activity theActivity = anObject as Activity;
            if ((System.Object)theActivity == null)
            {
                throw new InvalidObjectAddIntoTeacherException("Se esperaba un objeto del tipo [Activity]");
            }
            bool ActivityValidationId = IsIdValid(theActivity);
            bool ActivityValidationName = IsNameValid(theActivity);
            bool ActivityValidationCost = IsCostValid(theActivity);
            return ActivityValidationId && ActivityValidationName && ActivityValidationCost;
        }
    }
}
