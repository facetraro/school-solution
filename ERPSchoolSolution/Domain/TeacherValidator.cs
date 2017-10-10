using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TeacherValidator : IValidator
    {
        public bool IsValid(Object anObject)
        {
            Teacher theTeacher = anObject as Teacher;
            return theTeacher.Id > 0 && theTeacher.Name.Length > 0 && theTeacher.LastName.Length > 0;
        }
    }
    
}
