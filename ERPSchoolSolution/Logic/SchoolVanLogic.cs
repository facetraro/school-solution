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
        private Route RouteBest;
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
        private bool IsStudentAlreadyDeilvered(Student aStudent, Route route)
        {
            if (route.IsStudentInRoute(aStudent))
            {
                return true;
            }

            return false;
        }
        private bool AllStudentsAlreadyDelivered(List<Student> allStudents, Route route)
        {
            foreach (Student aStudent in allStudents)
            {
                if (!this.IsStudentAlreadyDeilvered(aStudent, route))
                {
                    return false;
                }
            }
            return true;
        }
        private void AddStudentToRoute(Route schoolVanRoute, Student aStudent)
        {
            schoolVanRoute.Add(aStudent);
        }
        private bool CanIAddStudentToRoute(Route schoolVanRoute, Student aStudent)
        {
            if (!IsStudentAlreadyDeilvered(aStudent, schoolVanRoute))
            {
                return true;
            }
            return false;
        }
        private List<Student> GetStudentsBySchoolVan(SchoolVan aSchoolVan)
        {
            List<Tuple<SchoolVan, List<Student>>> studentsAssignment = StudentAssignment();
            foreach (Tuple<SchoolVan, List<Student>> tuple in studentsAssignment)
            {
                if (tuple.Item1.Equals(aSchoolVan))
                {
                    return tuple.Item2;
                }
            }
            return new List<Student>();
        }

        private void btAux(Route route, List<Student> students, int actualCapacitiy)
        {
            if (AllStudentsAlreadyDelivered(students, route))
            {
                Route bestSolutionRoute = RouteBest;
                if (route.TotalDistance() < bestSolutionRoute.TotalDistance())
                {
                    bestSolutionRoute = route.Clone();
                    RouteBest = bestSolutionRoute.Clone();
                }
            }
            else
            {
                foreach (Student aStudent in students)
                {
                    if (CanIAddStudentToRoute(route, aStudent))
                    {
                        if (!(route.TheSchoolVan.Capacity <= actualCapacitiy))
                        {
                            AddStudentToRoute(route, aStudent);
                            btAux(route, students, actualCapacitiy + 1);
                            IRouteObject routeObject = route.TheRoute.Last();
                            route.RemoveLast();
                        }
                        else
                        {
                            int newCapacity = 0;
                            route.TheRoute.Add(new Coordinate());
                            btAux(route, students, newCapacity);
                            IRouteObject routeObject = route.TheRoute.Last();
                            route.RemoveLast();
                        }

                    }
                }
            }
        }

        public void bt(Route schoolVanRoute, List<Student> studentsBySchoolVan)
        {
            schoolVanRoute.TheRoute.Add(new Coordinate());
            Route unSolved = new Route();
            Coordinate farAway = new Coordinate();
            farAway.X = 99999999;
            farAway.Y = 99999999;
            unSolved.TheRoute.Add(farAway);
            RouteBest = unSolved;
            btAux(schoolVanRoute, studentsBySchoolVan, 0);
        }
        
        public void AddSchoolCoordinate(Route theRoute)
        {
            theRoute.Add(new Coordinate());
        }
  
        private List<Route> FindBestRoutes()
        {
            Singleton theRepository = Singleton.Instance;
            List<SchoolVan> allSchoolVans = theRepository.SchoolVans;
            SortSchoolVans schoolVanSort = new SortSchoolVans(); ;
            List<SchoolVan> sortedSchoolVans = schoolVanSort.GenerateSortedList(allSchoolVans);

            List<Route> bestRoutes = new List<Route>();
            foreach (SchoolVan aSchoolVan in sortedSchoolVans)
            {
                Route schoolVanRoute = new Route();
                schoolVanRoute.TheSchoolVan = aSchoolVan;
                List<Student> studentsBySchoolVan = GetStudentsBySchoolVan(aSchoolVan);
                bt(schoolVanRoute, studentsBySchoolVan);
                Route bestSolutionRoute = RouteBest.Clone();
                bestRoutes.Add(bestSolutionRoute.Clone());
            }
            return bestRoutes;
        }
        List<Student> SelectLessStudents(int schoolVansWithMoreStudents, int actualLoop, int studentsPerSchoolVanFloor)
        {
            Singleton theRepository = Singleton.Instance;
            List<Student> allStudents = theRepository.Students;
            SortStudents studentSort = new SortStudents();
            List<Student> sortedStudent = studentSort.GenerateSortedList(allStudents);
            List<Student> studentsToSchoolVan = new List<Student>();
            for (int i = actualLoop; i < actualLoop + studentsPerSchoolVanFloor; i++)
            {
                studentsToSchoolVan.Add(sortedStudent.ElementAt(i));

            }
            actualLoop = actualLoop + studentsPerSchoolVanFloor;
            return studentsToSchoolVan;
        }
        List<Student> SelectStudents(int schoolVansWithMoreStudents, int actualLoop, int studentsPerSchoolVanFloor)
        {
            Singleton theRepository = Singleton.Instance;
            List<Student> allStudents = theRepository.Students;
            SortStudents studentSort = new SortStudents();
            List<Student> sortedStudent = studentSort.GenerateSortedList(allStudents);
            List<Student> studentsToSchoolVan = new List<Student>();
            if (schoolVansWithMoreStudents >= actualLoop)
            {
                studentsToSchoolVan = SelectLessStudents(schoolVansWithMoreStudents, actualLoop, studentsPerSchoolVanFloor + 1);
            }
            else
            {
                studentsToSchoolVan = SelectLessStudents(schoolVansWithMoreStudents, actualLoop, studentsPerSchoolVanFloor);
            }
            return studentsToSchoolVan;
        }
        private List<Student> SelectStudentsToSchoolVan(int actualLoop, double studentsPerSchoolVan)
        {

            Singleton theRepository = Singleton.Instance;
            List<Student> studentsToSchoolVan;
            int countAllSchoolVans = theRepository.SchoolVans.Count;
            double result = studentsPerSchoolVan - Math.Truncate(studentsPerSchoolVan);
            int schoolVansWithMoreStudents = (int)(result * countAllSchoolVans);

            int studentsPerSchoolVanFloor = (int)Math.Floor(studentsPerSchoolVan);
            if (schoolVansWithMoreStudents != 0)
            {
                studentsToSchoolVan = SelectStudents(schoolVansWithMoreStudents, actualLoop, studentsPerSchoolVanFloor);
            }
            else
            {
                studentsToSchoolVan = SelectLessStudents(schoolVansWithMoreStudents, actualLoop, studentsPerSchoolVanFloor);
            }
            return studentsToSchoolVan;
        }
        public List<Tuple<SchoolVan, List<Student>>> StudentAssignment()
        {
            List<Tuple<SchoolVan, List<Student>>> assignment = new List<Tuple<SchoolVan, List<Student>>>();
            Singleton theRepository = Singleton.Instance;
            List<SchoolVan> allSchoolVans = theRepository.SchoolVans;
            List<Student> allStudent = theRepository.Students;
            double countAllSchoolVans = allSchoolVans.Count;
            double countAllStudents = allStudent.Count;
            double studentsPerSchoolVan = (countAllStudents / countAllSchoolVans);
            SortSchoolVans schoolVanSort = new SortSchoolVans(); ;
            List<SchoolVan> sortedSchoolVans = schoolVanSort.GenerateSortedList(allSchoolVans);
            SortStudents studentSort = new SortStudents();
            List<Student> sortedStudent = studentSort.GenerateSortedList(allStudent);
            int actualLoop = 0;
            foreach (SchoolVan aSchoolVan in sortedSchoolVans)
            {
                List<Student> studentsToSchoolVan = SelectStudentsToSchoolVan(actualLoop, studentsPerSchoolVan);
                actualLoop = actualLoop + studentsToSchoolVan.Count;
                Tuple<SchoolVan, List<Student>> newAssignment = new Tuple<SchoolVan, List<Student>>(aSchoolVan, studentsToSchoolVan);

                assignment.Add(newAssignment);
            }
            return assignment;
        }
        public List<Route> GetBestRoutes()
        {
            if (CanIGetBestRoutes())
            {
                return FindBestRoutes();
            }
            return new List<Route>();
        }
    }
}

