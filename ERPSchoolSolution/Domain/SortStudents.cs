using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SortStudents
    {
        public SortStudents()
        {

        }
        public List<Student> GenerateSortedList(List<Student> toSort)
        {
            List<Student> sortedList = new List<Student>();
            foreach (Student aStudent in toSort)
            {
                sortedList.Add(aStudent);
            }
            sortedList.Sort(new SortStudentById());
            return sortedList;
        }
    }
}
