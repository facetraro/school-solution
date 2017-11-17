using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CleanDB
    {
        public void EmptyDB()
        {
            List<IDBAccess> access = new List<IDBAccess>();
            access.Add(new SubscriptionAccess());
            access.Add(new StudentAccess());
            access.Add(new TeacherAccess());
            access.Add(new SubjectAccess());
            access.Add(new SchoolVanAccess());
            foreach (IDBAccess entity in access)
            {
                entity.Empty();
            }
        }
    }
}
