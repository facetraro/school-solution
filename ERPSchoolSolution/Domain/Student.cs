using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Student : Person, IRouteObject
    {
        private int ci;
        private int studentNumber;
        private Coordinate coordinates;
        private List<Subject> subjects;
        public Student()
        {
            Id = 0;
            Name = "defaultname";
            LastName = "defaultlastname";
            coordinates = new Coordinate();
            subjects = new List<Subject>();
        }
        public Coordinate GetCoordinates()
        {
            return coordinates;
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
        public override string ToString()
        {
            return "Alumno: " + Name + " " + LastName + " [" + StudentNumber + "]";
        }
        public bool IsInscriptedSubject(Subject aSubject)
        {
            return subjects.Contains(aSubject);
        }

        public string PrintToRoute()
        {
           return (this.Name + " " + GetCoordinates().PrintCoordinate());
        }
    }
}