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
        public Subject()
        {
            this.Code = "";
            this.Name = "";
        }
        public Subject(string code, string name)
        {
            this.Code = code;
            this.Name = name;
        }
        public bool IsCodeValid()
        {
            return this.Code != null;
        }
        public bool IsValid()
        {
            return IsCodeValid();
        }
        public override bool Equals(object aSubject)
        {
            Subject theSubject = aSubject as Subject;
            return (this.Code.Equals(theSubject.Code));

        }
    }
}
