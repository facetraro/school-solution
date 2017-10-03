using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SchoolVan
    {
        public int Id { get; set; }

        public override bool Equals(object aSchoolVan)
        {
            return true;
        }
    }
}
