using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Student : Person
    {
        public int Ci { get; set; }
        public int StudentNumber { get; set; }
        public Coordinate Coordinates { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
