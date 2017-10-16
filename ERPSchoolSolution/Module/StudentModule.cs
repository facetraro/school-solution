using Domain;
using Exceptions;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void LoadFields(Object anObject, TextBox textNameStudent, TextBox textLastNameStudent, TextBox textStudentNumber, NumericUpDown numericCi, NumericUpDown numericX, NumericUpDown numericY, ListBox list, ListBox listOtherSubject)
        {
            Student student = anObject as Student;
            textNameStudent.Text = student.Name;
            textLastNameStudent.Text = student.LastName;
            textStudentNumber.Text = student.StudentNumber + "";
            numericCi.Value = student.Ci;
            numericX.Value = student.Coordinates.X;
            numericY.Value = student.Coordinates.Y;
            SubjectLogic logic = new SubjectLogic();
            foreach (Subject item in logic.GetAllSubjects())
            {
                if (student.Subjects.Contains(item))
                {
                    list.Items.Add(item);
                }
                else
                {
                    listOtherSubject.Items.Add(item);
                }
            }
        }

        public void ModifyStudent(object selectedObject, string name, string lastName, int ci, int coordinateX, int coordinateY, List<Object> subjects)
        {
            StudentLogic logic = new StudentLogic();
            Student newStudent = new Student();
            Student oldStudent = (Student)selectedObject;
            newStudent.Id = oldStudent.Id;
            newStudent.StudentNumber = oldStudent.StudentNumber;
            newStudent.Ci = ci;
            newStudent.Coordinates = new Coordinate();
            newStudent.Coordinates.X = coordinateX;
            newStudent.Coordinates.Y = coordinateY;
            newStudent.Subjects = new List<Subject>();
            newStudent.Name = name;
            newStudent.LastName = lastName;
            foreach (Object item in subjects)
            {
                newStudent.Subjects.Add((Subject)item);
            }
            newStudent.Id = logic.GetNextIdFree();
            logic.Modify(selectedObject, newStudent);
        }


        public void LoadAllStudents(ListBox list)
        {
            StudentLogic logic = new StudentLogic();
            List<Student> allObjects = new List<Student>();
            allObjects = logic.GetAllStudents();
            if (allObjects.Count == 0)
            {
                throw new NoStudentsInSystemException("No hay alumnos ingresados en el sistema");
            }
            foreach (Student item in allObjects)
            {
                list.Items.Add(item);
            }
        }
        public void RemoveStudent(object selectedObject)
        {
            if (!(selectedObject is Student))
            {
                throw new ObjectIsNotSubjectException("Se esperaba un objeto del tipo [Student]");
            }
            Student toDelete = selectedObject as Student;
            StudentLogic logic = new StudentLogic();
            logic.Remove(toDelete);
        }
    }
}
