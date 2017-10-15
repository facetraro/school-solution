using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    public class SubjectModule : ModuleClass
    {
        public void AddNewSubject(string name)
        {
            SubjectLogic logic = new SubjectLogic();
            logic.AddNewSubject(name);
        }
    }
}
