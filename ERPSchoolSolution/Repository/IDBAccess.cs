using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    interface IDBAccess
    {
        void Add(Object anObject);
        void Remove(Object anObject);
        void Modify(Object anObject);
        void Empty();
         
    }
}
