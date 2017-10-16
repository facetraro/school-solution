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
    public class TeacherModule : ModuleClass
    {
        public void AddNewTeacher(string name, string lastName, List<Object> subjects)
        {
            TeacherLogic logic = new TeacherLogic();
            Teacher newTeacher = new Teacher();
            newTeacher.Id = logic.GetNextIdFree();
            newTeacher.Subjects = new List<Subject>();
            newTeacher.Name = name;
            newTeacher.LastName = lastName;
            foreach (Object item in subjects)
            {
                newTeacher.Subjects.Add((Subject)item);
            }
            logic.Add(newTeacher);
        }

        public void LoadFields(Object anObject, TextBox textName, TextBox textLastName, ListBox list, ListBox listOtherSubject)
        {
            Teacher teacher = anObject as Teacher;
            textName.Text = teacher.Name;
            textLastName.Text = teacher.LastName;
            SubjectLogic logic = new SubjectLogic();
            foreach (Subject item in logic.GetAllSubjects())
            {
                if (teacher.Subjects.Contains(item))
                {
                    list.Items.Add(item);
                }
                else
                {
                    listOtherSubject.Items.Add(item);
                }
            }
        }

        public void LoadSubjectsByTeacher(Object anObject, ListBox listSubjects)
        {
            Teacher teacher = anObject as Teacher;
            foreach (Subject item in teacher.Subjects)
            {
                listSubjects.Items.Add(item);
            }
        }

        public void ModifyTeacher(object selectedObject, string name, string lastName, List<Object> subjects)
        {
            TeacherLogic logic = new TeacherLogic();
            Teacher newTeacher = new Teacher();
            Teacher oldTeacher = (Teacher)selectedObject;
            newTeacher.Id = oldTeacher.Id;
            newTeacher.Subjects = new List<Subject>();
            newTeacher.Name = name;
            newTeacher.LastName = lastName;
            foreach (Object item in subjects)
            {
                newTeacher.Subjects.Add((Subject)item);
            }
            logic.Modify(selectedObject, newTeacher);
        }


        public void LoadAllTeacher(ListBox list)
        {
            TeacherLogic logic = new TeacherLogic();
            List<Teacher> allObjects = new List<Teacher>();
            allObjects = logic.GetAllTeachers();
            if (allObjects.Count == 0)
            {
                throw new NoTeachersInSystemException("No hay profesores ingresados en el sistema");
            }
            foreach (Teacher item in allObjects)
            {
                list.Items.Add(item);
            }
        }
        public void RemoveStudent(object selectedObject)
        {
            if (!(selectedObject is Student))
            {
                throw new ObjectIsNotSubjectException("Se esperaba un objeto del tipo [Teacher]");
            }
            Student toDelete = selectedObject as Student;
            StudentLogic logic = new StudentLogic();
            logic.Remove(toDelete);
        }
    }
}
