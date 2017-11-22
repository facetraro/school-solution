using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSchoolValidator
{
    public class Subject
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public Subject()
        {
            this.Code = "";
            this.Name = "";
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
        }
        public override bool Equals(object aSubject)
        {
            Subject theSubject = aSubject as Subject;
            if ((System.Object)theSubject == null)
            {
                return false;
            }
            return (this.Code.Equals(theSubject.Code));
        }
        public override string ToString()
        {
            return Name + " [" + Code + "]";
        }
    }
}
