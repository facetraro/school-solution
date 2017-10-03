using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SchoolVan
    {
        private int id;
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public override bool Equals(object aSchoolVan)
        {
            SchoolVan theSchoolVan = aSchoolVan as SchoolVan;
            if ((System.Object)theSchoolVan == null)
            {
                return false;
            }
            return (this.Id == theSchoolVan.Id);
        }
    }
}
