﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class ActivityPersistanceException : Exception
    {
        public ActivityPersistanceException(string message) : base(message)
        {
        }
    }
}
