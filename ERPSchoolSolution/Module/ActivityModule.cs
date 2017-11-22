using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Exceptions;
using Logic;

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
