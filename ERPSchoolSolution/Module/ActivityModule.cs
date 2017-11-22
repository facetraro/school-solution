using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Exceptions;
using Logic;
using Repository;

namespace Module
{
    public class ActivityModule : ModuleClass
    {
        public ActivityModule()
        {
            this.Name = "Gestión Actividades";
            this.Description = "Sector que permite gestionar las actividades";
        }

        public void AddNewActivity(string name, DateTime date, int cost)
        {
            ActivityLogic logic = new ActivityLogic();
            Activity newActivity = new Activity();
            newActivity.Name = name;
            newActivity.Date = date;
            newActivity.Cost = cost;
            newActivity.ActivityPayments = new List<ActivityPayment>();
            logic.Add(newActivity);
        }

        public void ModifyActivity(object selectedObject, string name, int cost, DateTime date)
        {
            ActivityLogic logic = new ActivityLogic();
            Activity newActivity = new Activity();
            Activity oldActivity = (Activity)selectedObject;
            newActivity.Id = oldActivity.Id;
            newActivity.Name = name;
            newActivity.Cost = cost;
            newActivity.Date = date;
            logic.Modify(selectedObject, newActivity);
        }

        public void RemoveActivity(object selectedObject)
        {
            if (!(selectedObject is Activity))
            {
                throw new WrongObjectException("Se esperaba un objeto del tipo [Activity]");
            }
            Activity toDelete = selectedObject as Activity;
            ActivityLogic logic = new ActivityLogic();
            logic.Remove(toDelete);
        }
        public void LoadAllActivities(ListBox list)
        {
            list.Items.Clear();
            ActivityLogic logic = new ActivityLogic();
            List<Activity> allObjects = new List<Activity>();
            allObjects = logic.GetAllActivities();
            if (allObjects.Count == 0)
            {
                throw new NoActivityInSystemException("No hay Actividades ingresadas en el sistema");
            }
            foreach (Activity item in allObjects)
            {
                list.Items.Add(item);
            }
        }
        private bool StudentHasAlreadyPaid(Student student, List<ActivityPayment> activityPayments)
        {
            bool alreadyPaid = false;
            foreach (ActivityPayment item in activityPayments)
            {
                if (item.Student.Equals(student))
                {
                    alreadyPaid = true;
                }
            }
            return alreadyPaid;
        }
        public void LoadStudentsOfSelectedActivity(ListBox list, object selectedActivity)
        {
            list.Items.Clear();
            Activity selected = selectedActivity as Activity;
            List<ActivityPayment> payments = new List<ActivityPayment>();
            ActivityPaymentAccess context = new ActivityPaymentAccess();
            foreach (ActivityPayment item in selected.ActivityPayments)
            {
                ActivityPayment fullPayment = context.Get(item.Id);
                payments.Add(fullPayment);
            }
            selected.ActivityPayments = payments;
            StudentLogic studentLogic = new StudentLogic();
            List<Student> allStudents = studentLogic.GetAllStudents();
            List<Student> listStudentsOfSelectedActivity = new List<Student>();
            foreach (Student item in allStudents)
            {
                if (!StudentHasAlreadyPaid(item, selected.ActivityPayments))
                {
                    list.Items.Add(item);
                }
            }
            if (list.Items.Count == 0)
            {
                throw new NoStudentsInSystemException("No hay estudiantes en el sistema para pagar esa actividad");
            }
        }

        public void LoadFields(Object anObject, TextBox textIDActivity, TextBox textNameActivity, TextBox textCostActivity, DateTimePicker date)
        {
            Activity activity = anObject as Activity;
            textIDActivity.Text = activity.Id.ToString();
            textNameActivity.Text = activity.Name;
            textCostActivity.Text = activity.Cost.ToString();
            date.Value = activity.Date;
        }
    }
}
