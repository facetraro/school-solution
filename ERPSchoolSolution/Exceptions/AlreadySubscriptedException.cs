﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class AlreadySubscriptedException : Exception
    {
        public AlreadySubscriptedException(string message) : base(message)
        {
        }
    }
}
