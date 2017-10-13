using System;
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
        private bool CanIAdd(Object anObject)
        {
            SubjectValidator validator = new SubjectValidator();
            return validator.IsValid(anObject) && !Exists(anObject);
        }

        public void Add(Object anObject)
        {

            if (CanIAdd(anObject)){
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
            Singleton theRepository = Singleton.Instance;
            Subject newSubject = anObject as Subject;
            theRepository.Subjects.Remove(newSubject);
        }
        private bool CanIModify(Object oldObject, Object newObject)
        {
            return Exists(oldObject) && CanIAdd(newObject);

        }
        public void Modify(Object oldObject, Object newObject)
        {
            if (CanIModify(oldObject,newObject))
            {
                this.Remove(oldObject);
                this.Add(newObject);
            }
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
