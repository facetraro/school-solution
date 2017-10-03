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

        public bool IsValid()
        {
            return this.Code != null;
        }
       
        public override bool Equals(object aSubject)
        {
            Subject theSubject = aSubject as Subject;
            return (this.Code.Equals(theSubject.Code));

        }

    }
}
