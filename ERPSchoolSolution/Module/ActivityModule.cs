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

        public void AddNewActivity(string name, DateTime date, int cost, List<ActivityPayment> listActivityPayments)
        {
            ActivityLogic logic = new ActivityLogic();
            Activity newActivity = new Activity();
            newActivity.Name = name;
            newActivity.Date = date;
            newActivity.Cost = cost;
            foreach (Object item in listActivityPayments)
            {
                newActivity.ActivityPayments.Add((ActivityPayment)item);
            }
            logic.Add(newActivity);
        }

        public void ModifyActivity(object selectedObject, string name, int cost, DateTime date)
        {
            ActivityLogic logic = new ActivityLogic();
            Activity newActivity = new Activity();
            Activity oldActivity = (Activity)selectedObject;
            newActivity.Id = oldActivity.Id;
            newActivity.Name = oldActivity.Name;
            newActivity.Cost = oldActivity.Cost;
            newActivity.Date = new DateTime();

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

        public void LoadFields(Object anObject, TextBox textNameActivity, TextBox textCostActivity, DateTimePicker date)
        {
            Activity activity = anObject as Activity;
            textNameActivity.Text = activity.Name;
            textCostActivity.Text = activity.Cost.ToString();
            date.Value = activity.Date;
        }
    }
}
