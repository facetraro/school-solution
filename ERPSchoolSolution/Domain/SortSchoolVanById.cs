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
            return anotherSchoolVan.Capacity.CompareTo(aSchoolVan.Capacity);
        }
    }
}

