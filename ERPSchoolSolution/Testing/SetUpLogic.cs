using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class SetUpLogic
    {
        protected void SetUp()
        {
            CleanDB cleaner = new CleanDB();
            cleaner.EmptyDB();
        }
    }
}
