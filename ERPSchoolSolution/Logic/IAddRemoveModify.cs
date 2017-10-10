using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface IAddRemoveModify
    {
        void Add(object anObject);
        void Remove(object anObject);
        void Modify(object anObject, object anotherObject);
        bool Exists(object anObject);
    }
}
