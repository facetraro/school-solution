﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    interface ARMEAccess : IDBAccess
    { 
        void Modify(Object anObject);     
    }
}
