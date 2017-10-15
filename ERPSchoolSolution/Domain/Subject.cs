using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
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
            return "Materia: " + Name + " [" + Code + "]";
        }
    }
}
