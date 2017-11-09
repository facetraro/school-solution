using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Module
{
    public class ActivityModule : ModuleClass
    {
        public ActivityModule()
        {
            this.Name = "Gestión Actividades";
            this.Description = "Sector que permite gestionar las actividades";
        }

        public void AddNewActivity(string name, DateTime date, int cost, List<Student> listParticipants)
        {
            /*ActivityLogic logic = new ActivityLogic();
            Activity newActivity = new Activity();
            newActivity.Id = logic.GetNextIdFree();
            newActivity.Name = name;
            newActivity.Date = date;
            newActivity.Cost = cost;
            foreach (Object item in listParticipants)
            {
                newActivity.Participants.Add((Student)item);
            }
            logic.Add(newActivity);*/
        }
    }
}
