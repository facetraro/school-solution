﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repository;
namespace Logic
{


    public class SubjectLogic
    {

        public void Add(Object anObject)
        {
            SubjectValidator validator = new SubjectValidator();
            if (validator.IsValid(anObject) && !Exists(anObject)){
                {
                    Singleton theRepository = Singleton.Instance;
                    Subject newSubject = anObject as Subject;
                    theRepository.Subjects.Add(newSubject);
                }
            }
        }
        public bool Exists(Object anObject)
        {
            Singleton theRepository = Singleton.Instance;
            Subject newSubject = anObject as Subject;
            return theRepository.Subjects.Contains(newSubject);
        }
        public void Remove(Object anObject)
        {

        }
        public void Modify(Object oldObject, Object newObject)
        {

        }

        public int Length()
        {
            Singleton theRepository = Singleton.Instance;
            return theRepository.Subjects.Count;
           
        }

        public void Empty()
        {
            Singleton theRepository = Singleton.Instance;
            theRepository.Subjects = new List<Subject>();
        }
    }
}
