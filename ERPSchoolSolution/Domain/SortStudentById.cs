using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SortStudentById : IComparer<Student>
    {
        public SortStudentById()
        {

        }
        public int Compare(Student aStudent, Student anotherStudent)
        {
            return aStudent.Id.CompareTo(anotherStudent.Id);
        }
    }
}

