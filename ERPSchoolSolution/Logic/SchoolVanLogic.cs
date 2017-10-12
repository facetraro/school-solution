using Domain;
using Exceptions;
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
        private bool CanIAdd(Object anObject)
        {
            SchoolVanValidator validator = new SchoolVanValidator();
            return validator.IsValid(anObject) && !Exists(anObject);
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
        private bool CanIModify(Object oldObject, Object newObject)
        {
            return (Exists(oldObject) && CanIAdd(newObject));
        }
        public void Modify(Object oldObject, Object newObject)
        {
            if (CanIModify(oldObject, newObject))
            {
                this.Remove(oldObject);
                this.Add(newObject);
            }
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
        public bool IsEmpty()
        {
            Singleton theRepository = Singleton.Instance;
            return theRepository.SchoolVans.Count == 0;
        }


        private bool IsStudentsEmpty()
        {
            StudentLogic logic = new StudentLogic();
            bool studentsEmpty = logic.IsEmpty();
            if (studentsEmpty)
            {
                throw new NoStudentsInSystemException("No Students in the system");
            }
            return studentsEmpty;
        }
        private bool IsSchoolVanEmpty()
        {
            bool schoolVanEmpty = this.IsEmpty();
            if (schoolVanEmpty)
            {
                throw new NoSchoolVanInSystemException("No School Vans in the system");
            }
            return schoolVanEmpty;
        }

        private bool CanIGetBestRoutes()
        {
            return !IsStudentsEmpty() && !IsSchoolVanEmpty();
        }
        private bool IsStudentAlreadyDeilvered(Student aStudent, List<Route> routes)
        {
            foreach (Route route in routes)
            {
                if (route.IsStudentInRoute(aStudent))
                {
                    return true;
                }
            }
            return false;
        }
        private bool AllStudentsAlreadyDelivered(List<Student> allStudents, List<Route> routes)
        {
            foreach (Student aStudent in allStudents)
            {
                if (this.IsStudentAlreadyDeilvered(aStudent, routes))
                {
                    return true;
                }
            }
            return false;
        }
        public List<Route> GetBestRoutes()
        {
            List<Route> newRoutes = new List<Route>();
            if (CanIGetBestRoutes())
            {
                Singleton theRepository = Singleton.Instance;
                List<SchoolVan> allSchoolVans = theRepository.SchoolVans;
                List<Student> allStudents = theRepository.Students;
                foreach (SchoolVan aSchoolVan in allSchoolVans)
                {
                    Route schoolVanRoute = new Route();
                    newRoutes.Add(schoolVanRoute);
                    Coordinate coor = new Coordinate();
                    
                    schoolVanRoute.Add(coor);
                    int studentsInSchoolVan = 0;
                    while((aSchoolVan.Capacity - studentsInSchoolVan)>=0 && !AllStudentsAlreadyDelivered(allStudents, newRoutes))
                    {
                        foreach (Student aStudent in allStudents)
                        {
                            if (!schoolVanRoute.IsStudentInRoute(aStudent))
                            {
                                studentsInSchoolVan++;
                                schoolVanRoute.Add(aStudent);
                            } 
                        }
                    }
                    schoolVanRoute.Add(coor);
                    studentsInSchoolVan = 0;
                   
                }
            }
            return newRoutes;
        }
    }
}

