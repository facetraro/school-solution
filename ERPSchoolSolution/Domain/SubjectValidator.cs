using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SubjectValidator : IValidator
    {
        public bool IsCodeValid(Subject theSubject)
        {

            return theSubject.Code != null && theSubject.Code != "";
        }
        public bool IsValid(Object anObject)
        {
            Subject theSubject = anObject as Subject;
            if ((System.Object)theSubject == null)
            {
                return false;
            }
            return IsCodeValid(theSubject);
        }        
    }
}