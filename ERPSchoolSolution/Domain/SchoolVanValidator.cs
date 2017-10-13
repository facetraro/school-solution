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
        private static int MIN_ID = 0;
        private bool ValidCapacity(SchoolVan aSchoolVan)
        {
            return (aSchoolVan.Capacity >= MIN_CAPACITY && aSchoolVan.Capacity <= MAX_CAPACITY);
        }
        private bool ValidId(SchoolVan aSchoolVan)
        {
            return (aSchoolVan.Id >= MIN_ID);
        }
        private bool AllAtributesAreValid(SchoolVan theSchoolVan)
        {
            return ValidCapacity(theSchoolVan) && ValidId(theSchoolVan);
        }
        public bool IsValid(object anObject)
        {
            SchoolVan theSchoolVan = anObject as SchoolVan;
            if ((System.Object)theSchoolVan == null)
            {
                return false;
            }
            return AllAtributesAreValid(theSchoolVan);
        }
    }
}
