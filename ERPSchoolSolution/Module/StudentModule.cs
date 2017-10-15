using Domain;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    public class StudentModule : ModuleClass
    {
        public void AddNewStudent(string name, string lastName, int ci, int coordinateX, int coordinateY, List<Object> subjects)
        {
            StudentLogic logic = new StudentLogic();
            Student newStudent = new Student();
            newStudent.Ci = ci;
            newStudent.Coordinates = new Coordinate();
            newStudent.Coordinates.X = coordinateX;
            newStudent.Coordinates.Y = coordinateY;
            newStudent.StudentNumber = logic.GetNextIdFree();
            newStudent.Subjects = new List<Subject>();
            newStudent.Name = name;
            newStudent.LastName = lastName;
            foreach (Object item in subjects)
            {
                newStudent.Subjects.Add((Subject)item);
            }
            newStudent.Id = logic.GetNextIdFree();
            logic.Add(newStudent);
        }
    }
}
