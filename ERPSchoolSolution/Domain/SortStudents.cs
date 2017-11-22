using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSchoolValidator
{
    public class SortStudents
    {
        public SortStudents()
        {

        }
        private List<Student> CopyStudentList(List<Student> toCopy)
        {
            List<Student> copyList = new List<Student>();
            foreach (Student aStudent in toCopy)
            {
                copyList.Add(aStudent);
            }
            return copyList;
        }
        public List<Student> GenerateSortedList(List<Student> toSort)
        {
            List<Student> sortedList = CopyStudentList(toSort);
            sortedList.Sort(new SortStudentById());
            return sortedList;
        }
    }
}
