using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSchoolValidator
{
    public class SortSchoolVans
    {
        public SortSchoolVans()
        {

        }
        private List<SchoolVan> CopySchoolVanList(List<SchoolVan> toCopy)
        {
            List<SchoolVan> copyList = new List<SchoolVan>();
            foreach (SchoolVan aSchoolVan in toCopy)
            {
                copyList.Add(aSchoolVan);
            }
            return copyList;
        }
        public List<SchoolVan> GenerateSortedList(List<SchoolVan> toSort)
        {
            List<SchoolVan> sortedList = CopySchoolVanList(toSort);
            sortedList.Sort(new SortSchoolVanById());
            return sortedList;
        }
    }
}
