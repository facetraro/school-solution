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
        bool Exists(object anObject);
    }
}
