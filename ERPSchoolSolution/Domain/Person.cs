using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Person
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String LastName { get; set; }
        public Person()
        {
            Id = 0;
            Name = "defaultname";
            LastName = "defaultlastname";
        }
        public override bool Equals(object aPerson)
        {
            Person thePerson = aPerson as Person;
            if (thePerson == null)
            {
                return false;
            }
            return (this.Id == thePerson.Id);
        }
    }
}
