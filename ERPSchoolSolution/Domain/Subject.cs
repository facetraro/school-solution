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
