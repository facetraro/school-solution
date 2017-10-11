using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SchoolVanValidator : IValidator
    {
        private static int MAX_CAPACITY = 15;
        private static int MIN_CAPACITY = 1;
        private bool validCapacity(SchoolVan aSchoolVan)
        {
            return (aSchoolVan.Capacity >= MIN_CAPACITY && aSchoolVan.Capacity <= MAX_CAPACITY);
        } 
        public bool IsValid(object anObject)
        {
            SchoolVan theSchoolVan = anObject as SchoolVan;
            if ((System.Object)theSchoolVan == null)
            {
                return false;
            }
            return validCapacity(theSchoolVan) && 0<=theSchoolVan.Id;
        }
    }
}
