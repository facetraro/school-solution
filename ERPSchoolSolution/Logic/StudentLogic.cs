using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class StudentLogic : IAddRemoveModify
    {
        public void Add(Object anObject)
        {
            Singleton theRepository = Singleton.Instance;

     
            if (!Exists(anObject))
            {
                Student toAdd = anObject as Student;
                     theRepository.Students.Add(toAdd);

            }
       
        }
        public void Remove(Object anObject)
        {

        }
        public void Modify(Object anObject, Object anotherObject)
        {

        }
        public bool Exists(Object anObject)
        {
            Singleton theRepository = Singleton.Instance;
            Student lookUp = anObject as Student;
            return theRepository.Students.Contains(lookUp);
        }
        public int Length()
        {
            Singleton theRepository = Singleton.Instance;
            return theRepository.Students.Count;
        }
    }
}
