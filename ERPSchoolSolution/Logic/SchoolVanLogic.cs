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

        public void Add(Object anObject)
        {
            Singleton theRepository = Singleton.Instance;
            SchoolVan newSchoolVan = anObject as SchoolVan;
            theRepository.SchoolVans.Add(newSchoolVan);
        }
        public bool Exists(Object anObject)
        {
            Singleton theRepository = Singleton.Instance;
            SchoolVan newSchoolVan = anObject as SchoolVan;
            return theRepository.SchoolVans.Contains(newSchoolVan);
        }
        public void Delete(Object anObject)
        {
            Singleton theRepository = Singleton.Instance;
            SchoolVan newSchoolVan = anObject as SchoolVan;
            theRepository.SchoolVans.Remove(newSchoolVan);
        }
        public void Empty()
        {
            Singleton theRepository = Singleton.Instance;
            theRepository.SchoolVans = new List<SchoolVan>();
        }
    }
}
