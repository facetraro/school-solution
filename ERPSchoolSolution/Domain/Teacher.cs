﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSchoolValidator
{
    public class Teacher : Person
    {
        public List<Subject> Subjects { get; set; }

        public Teacher()
        {
            Id = 0;
            Name = "defaultname";
            LastName = "defaultlastname";
            Subjects = new List<Subject>();
        }
        public override string ToString()
        {
            return  Name + " " + LastName + " [" + Id + "]";
        }
    }
}
