﻿using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class TeacherLogic 
    {
        public void Insert(Object anObject)
        {
            Singleton theRepository = Singleton.Instance;
            Teacher toAdd = anObject as Teacher;
            theRepository.Teachers.Add(toAdd);
        }
        public bool CanIAdd(Object anObject)
        {
            if(anObject is Teacher)
            {
                return !this.Exists(anObject);
            }
            return false;
        }
        public void Add(Object anObject)
        {
            if (CanIAdd(anObject))
            {
                Insert(anObject);
            }
        }   
        public bool Exists(Object anObject)
        {
            Singleton theRepository = Singleton.Instance;
            Teacher lookUp = anObject as Teacher;
            return theRepository.Teachers.Contains(lookUp);
        }
        public int Length()
        {
            Singleton theRepository = Singleton.Instance;
            return theRepository.Teachers.Count;
        }
    }
}
