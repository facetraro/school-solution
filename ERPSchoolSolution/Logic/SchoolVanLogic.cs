using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class SchoolVanLogic : IAddRemoveModify
    {
        private bool IsObjectASchoolVan(Object anObject)
        {
            return anObject is SchoolVan;
        }
        private bool CanIAdd(Object anObject)
        {
            SchoolVanValidator validator = new SchoolVanValidator();
            return IsObjectASchoolVan(anObject) && validator.IsValid(anObject) && !Exists(anObject);
        }
        public void Add(Object anObject)
        {
            if (CanIAdd(anObject))
            {
                Singleton theRepository = Singleton.Instance;
                SchoolVan newSchoolVan = anObject as SchoolVan;
                theRepository.SchoolVans.Add(newSchoolVan);
            }
        }
        public bool Exists(Object anObject)
        {
            Singleton theRepository = Singleton.Instance;
            SchoolVan newSchoolVan = anObject as SchoolVan;
            return theRepository.SchoolVans.Contains(newSchoolVan);
        }
        public void Remove(Object anObject)
        {
            Singleton theRepository = Singleton.Instance;
            SchoolVan newSchoolVan = anObject as SchoolVan;
            theRepository.SchoolVans.Remove(newSchoolVan);
        }
        public void Modify(Object oldObject, Object newObject)
        {
            this.Remove(oldObject);
            this.Add(newObject);
        }
        public int Length()
        {
            Singleton theRepository = Singleton.Instance;
            return theRepository.SchoolVans.Count;
        }
        public void Empty()
        {
            Singleton theRepository = Singleton.Instance;
            theRepository.SchoolVans = new List<SchoolVan>();
        }
    }
}
