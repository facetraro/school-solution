using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SortSchoolVanById : IComparer<SchoolVan>
    {
        public SortSchoolVanById()
        {

        }
        public int Compare(SchoolVan aSchoolVan, SchoolVan anotherSchoolVan)
        {
            if (aSchoolVan == null)
            {
                if (anotherSchoolVan == null)
                {
                    return 0;
                }
                return -1;
            }
            else
            {
                if (anotherSchoolVan == null)
                {
                    return 1;
                }
            }
            return anotherSchoolVan.Capacity.CompareTo(aSchoolVan.Capacity);
        }
    }
}

