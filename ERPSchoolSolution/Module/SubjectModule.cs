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
    public class SubjectModule : ModuleClass
    {
        public void AddNewSubject(string name)
        {
            SubjectLogic logic = new SubjectLogic();
            logic.AddNewSubject(name);
        }
        public void LoadAllSubjects(ListBox list)
        {
            SubjectLogic logic = new SubjectLogic();
            List<Subject> allObjects = new List<Subject>();
            allObjects = logic.GetAllSubjects();
            if (allObjects.Count == 0)
            {
                throw new NoSubjectInSystemException("No hay Materias ingresadas en el sistema");
            }
            foreach (Subject item in allObjects)
            {
                list.Items.Add(item);
            }

        }

        public void LoadFields(object selectedObject, TextBox textName, TextBox textCode)
        {
            if (!(selectedObject is Subject))
            {
                throw new ObjectIsNotSubjectException("Se esperaba un objeto del tipo [Subject]");
            }
            Subject theSubject = selectedObject as Subject;
            textName.Text = theSubject.Name;
            textCode.Text = theSubject.Code;
        }

        public void ModifySubject(object selectedObject, TextBox textName, TextBox textCode)
        {
            if (!(selectedObject is Subject))
            {
                throw new ObjectIsNotSubjectException("Se esperaba un objeto del tipo [Subject]");
            }
            Subject oldSubject = selectedObject as Subject;
            SubjectLogic logic = new SubjectLogic();
            Subject newSubject = new Subject();
            newSubject.Name = textName.Text;
            newSubject.Code = textCode.Text;
            logic.Modify(oldSubject, newSubject);
        }
        public void RemoveSubject(object selectedObject)
        {
            if (!(selectedObject is Subject))
            {
                throw new ObjectIsNotSubjectException("Se esperaba un objeto del tipo [Subject]");
            }
            Subject toDelete = selectedObject as Subject;
            SubjectLogic logic = new SubjectLogic();
            logic.Remove(toDelete);
        }
    }
}
