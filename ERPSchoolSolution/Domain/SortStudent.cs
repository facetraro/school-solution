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
            if (aStudent == null)
            {
                if (anotherStudent == null)
                {
                    return 0;
                }
                return -1;
            }
            else
            {
                if (anotherStudent == null)
                {
                    return 1;
                }
            }
            return aStudent.Id.CompareTo(anotherStudent.Id);
        }
    }
}

