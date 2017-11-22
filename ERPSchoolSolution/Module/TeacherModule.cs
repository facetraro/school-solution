using ERPSchoolValidator;
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
        public TeacherModule()
        {
            this.Name = "Gestión Docente";
            this.Description = "Sector que pertime gestionar las acciones de Docente.";
        }
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

        public void LoadFields(Object anObject, TextBox textName, TextBox textCode, TextBox textLastName, ListBox list, ListBox listOtherSubject)
        {
            Teacher teacher = anObject as Teacher;
            textName.Text = teacher.Name;
            textLastName.Text = teacher.LastName;
            textCode.Text = teacher.Id+"";
            SubjectLogic logic = new SubjectLogic();
            List<Subject> allSubjects = logic.GetAllSubjects();
            foreach (Subject item in allSubjects)
            {
                if (teacher.Subjects.Contains(item))
                {
                    list.Items.Add(allSubjects.Find(x => x.Code == item.Code));
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
            SubjectLogic logic = new SubjectLogic();
            List<Subject> allSubjects = logic.GetAllSubjects();
            foreach (Subject item in allSubjects)
            {
                if (teacher.Subjects.Contains(item))
                {
                    listSubjects.Items.Add(allSubjects.Find(x => x.Code == item.Code));
                }   
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
        public void RemoveTeacher(object selectedObject)
        {
            if (!(selectedObject is Teacher))
            {
                throw new WrongObjectException("Se esperaba un objeto del tipo [Teacher]");
            }
            Teacher toDelete = selectedObject as Teacher;
            TeacherLogic logic = new TeacherLogic();
            logic.Remove(toDelete);
        }
    }
}
