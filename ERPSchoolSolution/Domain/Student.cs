using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Student : Person
    {
        private int ci { get; set; }
        private int studentNumber { get; set; }
        private Coordinate coordinates { get; set; }
        private List<Subject> subjects { get; set; }
        public Student()
        {
            Id = 0;
            Name = "defaultname";
            LastName = "defaultlastname";
            coordinates = new Coordinate();
            subjects = new List<Subject>();
        }

        public int Ci
        {
            get
            {
                return this.ci;
            }
            set
            {
                this.ci = value;
            }
        }
        public int StudentNumber
        {
            get
            {
                return this.studentNumber;
            }
            set
            {
                this.studentNumber = value;
            }
        }
        public Coordinate Coordinates
        {
            get
            {
                return this.coordinates;
            }
            set
            {
                this.coordinates = value;
            }
        }
        public List<Subject> Subjects
        {
            get
            {
                return this.subjects;
            }
            set
            {
                this.subjects = value;
            }
        }
        public bool IsInscriptedSubject(Subject aSubject)
        {
            return subjects.Contains(aSubject);
        }
    }
}