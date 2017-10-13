using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SortSchoolVans
    {
        public SortSchoolVans()
        {

        }
        public List<SchoolVan> GenerateSortedList(List<SchoolVan> toSort)
        {
            List<SchoolVan> sortedList = new List<SchoolVan>();
            foreach (SchoolVan aSchoolVan in toSort)
            {
                sortedList.Add(aSchoolVan);
            }
            sortedList.Sort(new SortSchoolVanById());
            return sortedList;
        }
    }
}
