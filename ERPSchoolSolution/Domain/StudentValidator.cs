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
            return aStudent.Ci >= MIN_CI;
        }
        private bool IsNameValid(Student aStudent)
        {
            return aStudent.Name.Length > 0;
        }
        private bool IsLastNameValid(Student aStudent)
        {
            return aStudent.LastName.Length > 0;
        }
        public bool IsValid(object anObject)
        {
            Student theStudent = anObject as Student;
            if ((System.Object)theStudent == null)
            {
                return false;
            }
            return IsCiValid(theStudent) && IsNameValid(theStudent) && IsLastNameValid(theStudent);
        }
    }
}
