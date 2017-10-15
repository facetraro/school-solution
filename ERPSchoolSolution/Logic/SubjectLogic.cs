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
        private string GenerateNewCode()
        {
            string posibleChars = "0123456789abcdefghijlkmnopqrstuvwxyz";
            string generatedCode = "";
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                generatedCode = generatedCode + posibleChars.ElementAt(rnd.Next(1, 34));
            }
            return generatedCode;
        }
        public List<Subject> GetAllSubjects()
        {
            Singleton repository = Singleton.Instance;
            return repository.Subjects;
        }

        private bool CanIAdd(Object anObject)
        {
            SubjectValidator validator = new SubjectValidator();
            return validator.IsValid(anObject) && !Exists(anObject);
        }
        
        public void AddNewSubject(string name)
        {
            Subject newSubject = new Subject();
            newSubject.Code = GenerateNewCode();
            newSubject.Name = name;
            this.Add(newSubject);
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
