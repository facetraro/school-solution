using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class StudentValidator : IValidator
    {
        public bool IsValid(object anObject)
        {
            Student theStudent = anObject as Student;
            return theStudent.Ci > 0 && theStudent.Name.Length> 0 && theStudent.LastName.Length > 0 && theStudent.Name.Length > 0;
        }
    }
}
