using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions;
namespace Domain
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
        
        public bool IsValid(Object anObject)
        {
            Activity theActivity = anObject as Activity;
            if ((System.Object)theActivity == null)
            {
                throw new InvalidObjectAddIntoTeacherException("Se esperaba un objeto del tipo [Activity]");
            }
            bool ActivityValidationId = IsIdValid(theActivity);
            return ActivityValidationId;
        }
    }
}
