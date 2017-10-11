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
            return (aTeacher.Id > 0);
        }
        private bool IsNameValid(Teacher aTeacher)
        {
            return (aTeacher.Name.Length > 0);
        }
        private bool IsLastNameValid(Teacher aTeacher)
        {
            return (aTeacher.LastName.Length > 0);
        }

        public bool IsValid(Object anObject)
        {
            Teacher theTeacher = anObject as Teacher;

            if ((System.Object)theTeacher == null)
            {
                return false;
            }
            return (IsIdValid(theTeacher) && IsNameValid(theTeacher) && IsLastNameValid(theTeacher));
        }
    }
}