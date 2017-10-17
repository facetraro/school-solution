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
        private static Coordinate SchoolCoordinate = new Coordinate();
        private static int BIG_INT_VALUE = 99999999;
        private bool CanIAdd(Object anObject)
        {
            SchoolVanValidator validator = new SchoolVanValidator();
            if (Exists(anObject))
            {
                throw new SchoolVanAlreadyExistsException("El id ingresado de camioneta ya existe");
            }
            return validator.IsValid(anObject) && !Exists(anObject);
        }
        private int GetBiggestIdSchoolVan(List<SchoolVan> list)
        {
            int biggestSoFar = 0;
            foreach (SchoolVan item in list)
            {
                if (item.Id > biggestSoFar) biggestSoFar = item.Id;
            }
            return biggestSoFar;
        }
        public int GetNextIdFree()
        {
            List<SchoolVan> list = GetSchoolVansSortedByCapacity();
            return (GetBiggestIdSchoolVan(list) + 1);
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
        private bool ModifyValidation(Object anObject, Object anotherObject)
        {
            SchoolVanValidator validator = new SchoolVanValidator();
            bool domainValidation = validator.IsValid(anotherObject);
            bool nonExists = !Exists(anotherObject);
            bool sameId = anObject.Equals(anotherObject);
            if (!(nonExists || sameId))
            {
                throw new SchoolVanAlreadyExistsException("El id ingresado de camioneta ya existe");
            }
            return domainValidation && (nonExists || sameId);
        }
        private bool CanIModify(Object oldObject, Object newObject)
        {
            return (Exists(oldObject) && ModifyValidation(oldObject, newObject));
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
            List<Student> students = new List<Student>();
            List<Tuple<SchoolVan, List<Student>>> studentsAssignment = StudentAssignment();
            foreach (Tuple<SchoolVan, List<Student>> tuple in studentsAssignment)
            {
                if (tuple.Item1.Equals(aSchoolVan))
                {
                    students = tuple.Item2;
                }
            }
            return students;
        }
        private void SaveNewBestSolution(Route route)
        {
            Route bestSolutionRoute = RouteBest;
            bestSolutionRoute = route.Clone();
            RouteBest = bestSolutionRoute.Clone();
        }

        private bool IsBestThanBestSolution(Route route)
        {
            Route bestSolutionRoute = RouteBest;
            return (route.TotalDistance() < bestSolutionRoute.TotalDistance());
        }
        private bool IFoundABestRoute(Route route, List<Student> students)
        {
            return (AllStudentsAlreadyDelivered(students, route) && IsBestThanBestSolution(route));
        }
        private void AddStudentToRoute(Route route, List<Student> students, Student student)
        {
            AddStudentToRoute(route, student);
            FindBestRouteForSchoolVan(route, students);
            IRouteObject routeObject = route.TheRoute.Last();
            route.RemoveLast();
        }
        private bool CanSchoolVanPickMoreStudents(SchoolVan aSchoolVan, Route actualRoute)
        {
            return !(aSchoolVan.Capacity <= actualRoute.NumberOfStudentsInThisRide());
        }

        private void ContinueLookingForMoreRotues(Route route, List<Student> students)
        {
            foreach (Student aStudent in students)
            {
                if (CanIAddStudentToRoute(route, aStudent))
                {
                    if (!CanSchoolVanPickMoreStudents(route.TheSchoolVan, route))
                    {
                        AddSchoolCoordinate(route);
                    }
                    AddStudentToRoute(route, students, aStudent);
                }
            }
        }
        private void FindBestRouteForSchoolVan(Route route, List<Student> students)
        {
            if (IFoundABestRoute(route, students))
            {
                SaveNewBestSolution(route);
            }
            else
            {
                ContinueLookingForMoreRotues(route, students);
            }
        }
        public void GetBestRouteForSchoolVan(Route schoolVanRoute, List<Student> studentsBySchoolVan)
        {
            AddSchoolCoordinate(schoolVanRoute);
            Route unSolved = new Route();
            Coordinate farAway = new Coordinate();
            farAway.X = BIG_INT_VALUE;
            farAway.Y = BIG_INT_VALUE;
            unSolved.TheRoute.Add(farAway);
            RouteBest = unSolved;
            FindBestRouteForSchoolVan(schoolVanRoute, studentsBySchoolVan);
        }
        private void AddSchoolCoordinate(Route theRoute)
        {
            theRoute.Add(SchoolCoordinate);
        }
        public List<SchoolVan> GetSchoolVansSortedByCapacity()
        {
            Singleton theRepository = Singleton.Instance;
            List<SchoolVan> allSchoolVans = theRepository.SchoolVans;
            SortSchoolVans schoolVanSort = new SortSchoolVans();
            List<SchoolVan> sortedSchoolVans = schoolVanSort.GenerateSortedList(allSchoolVans);
            return sortedSchoolVans;
        }
        private List<Student> GetStudentsSortedById()
        {
            Singleton theRepository = Singleton.Instance;
            List<Student> allStudents = theRepository.Students;
            SortStudents studentsSort = new SortStudents();
            List<Student> sortedStudents = studentsSort.GenerateSortedList(allStudents);
            return sortedStudents;
        }
        private List<Route> FindBestRoutes()
        {
            List<SchoolVan> sortedSchoolVans = GetSchoolVansSortedByCapacity();
            List<Route> bestRoutes = new List<Route>();
            foreach (SchoolVan aSchoolVan in sortedSchoolVans)
            {
                Route schoolVanRoute = new Route();
                schoolVanRoute.TheSchoolVan = aSchoolVan;
                List<Student> studentsBySchoolVan = GetStudentsBySchoolVan(aSchoolVan);
                GetBestRouteForSchoolVan(schoolVanRoute, studentsBySchoolVan);
                Route bestSolutionRoute = RouteBest.Clone();
                bestRoutes.Add(bestSolutionRoute.Clone());
            }
            return bestRoutes;
        }
        List<Student> SelectLessStudents(int schoolVansWithMoreStudents, int actualLoop, int studentsPerSchoolVanFloor)
        {
            Singleton theRepository = Singleton.Instance;
            List<Student> sortedStudent = GetStudentsSortedById();
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
            List<Student> sortedStudent = GetStudentsSortedById();
            List<Student> studentsToSchoolVan = new List<Student>();
            if (schoolVansWithMoreStudents >= actualLoop)
            {
                studentsToSchoolVan = SelectLessStudents(schoolVansWithMoreStudents, actualLoop, studentsPerSchoolVanFloor + 1);
                return studentsToSchoolVan;
            }
            studentsToSchoolVan = SelectLessStudents(schoolVansWithMoreStudents, actualLoop, studentsPerSchoolVanFloor);
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
        private double GetStudentsPerSchoolVan()
        {
            Singleton theRepository = Singleton.Instance;
            List<SchoolVan> sortedSchoolVans = GetSchoolVansSortedByCapacity();
            List<Student> sortedStudent = GetStudentsSortedById();
            double countAllSchoolVans = sortedSchoolVans.Count;
            double countAllStudents = sortedStudent.Count;
            double studentsPerSchoolVan = (countAllStudents / countAllSchoolVans);
            return studentsPerSchoolVan;
        }
        public List<Tuple<SchoolVan, List<Student>>> StudentAssignment()
        {
            List<Tuple<SchoolVan, List<Student>>> assignment = new List<Tuple<SchoolVan, List<Student>>>();
            List<SchoolVan> sortedSchoolVans = GetSchoolVansSortedByCapacity();
            double studentsPerSchoolVan = GetStudentsPerSchoolVan();
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
            List<Route> bestRoutes = new List<Route>();
            if (CanIGetBestRoutes())
            {
                bestRoutes = FindBestRoutes();
            }
            return bestRoutes;
        }
    }
}

