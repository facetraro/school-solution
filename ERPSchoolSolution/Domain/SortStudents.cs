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
        public List<Student> CopyStudentList(List<Student> toSort)
        {
            List<Student> newStudentList = new List<Student>();
            foreach (Student aStudent in toSort)
            {
                newStudentList.Add(aStudent);
            }
            return newStudentList;
        }

        public List<Student> GenerateSortedList(List<Student> toSort)
        {
            List<Student> studentList = CopyStudentList(toSort);
            studentList.Sort(new SortStudentById());
            return studentList;
        }
    }
}
