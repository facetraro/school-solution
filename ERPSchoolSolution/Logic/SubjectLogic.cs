using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
namespace Logic
{


    public class SubjectLogic
    {
        private Subject testSubject()
        {
            Subject aSubject = new Subject();
            aSubject.Name = "testSubject";
            aSubject.Code = "132";
            aSubject.Students = new List<Student>();
            aSubject.Teachers = new List<Teacher>();
            return aSubject;
        }

        public void Add(Object anObject)
        {
         
        }
        public bool Exists(Object anObject)
        {
            return true;
        }
        public void Remove(Object anObject)
        {

        }
        public void Modify(Object oldObject, Object newObject)
        {

        }
    }
}
