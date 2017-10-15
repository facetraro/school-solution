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
            List<Subject> allObjects = logic.GetAllSubjects();
            foreach (var item in allObjects)
            {
                list.Items.Add(item);
            }
        }

        public void LoadFields(object selectedObject, TextBox textName, TextBox textCode)
        {
            try
            {
                if (!(selectedObject is Subject))
                {
                    throw new ObjectIsNotSubjectException("Se esperaba un objeto del tipo [Subject]");
                }
                Subject theSubject = selectedObject as Subject;
                textName.Text = theSubject.Name;
                textCode.Text = theSubject.Code;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void ModifySubject(object selectedObject, TextBox textName, TextBox textCode)
        {

            try
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
                logic.Modify(oldSubject,newSubject);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
