using ERPSchoolValidator;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    public class AddTestData
    {
        public void AddTestDataToSystem()
        {
            Subject subject1 = new Subject();
            subject1.Name = "Matematicas";
            subject1.Code = "mate1";
            Subject subject2 = new Subject();
            subject2.Name = "Geografia";
            subject2.Code = "g1992";
            Subject subject3 = new Subject();
            subject3.Name = "Idioma Español";
            subject3.Code = "9ie54";
            Subject subject4 = new Subject();
            subject4.Name = "Ingles";
            subject4.Code = "5feng";
            Subject subject5 = new Subject();
            subject5.Name = "Educacion Fisica";
            subject5.Code = "edfi1";
            Subject subject6 = new Subject();
            subject6.Name = "Computacion";
            subject6.Code = "c2017";
            Subject subject7 = new Subject();
            subject7.Name = "Geometria";
            subject7.Code = "4g1me";
            Subject subject8 = new Subject();
            subject8.Name = "Canto";
            subject8.Code = "sing2";
            SubjectLogic subjectLogic = new SubjectLogic();
            subjectLogic.Add(subject1);
            subjectLogic.Add(subject2);
            subjectLogic.Add(subject3);
            subjectLogic.Add(subject4);
            subjectLogic.Add(subject5);
            subjectLogic.Add(subject6);
            subjectLogic.Add(subject7);
            subjectLogic.Add(subject8);

            StudentLogic studentLogic = new StudentLogic();

            Student student1 = new Student();
            student1.Id = 991;
            student1.StudentNumber = 991;
            student1.Name = "Juan";
            student1.LastName = "Rodriguez";
            student1.Ci = 46702345;
            student1.Coordinates.X = 24;
            student1.Coordinates.Y = -9;
            student1.Subjects.Add(subject1);
            student1.Subjects.Add(subject2);
            studentLogic.Add(student1);

            Student student2 = new Student();
            student2.Id = 992;
            student2.StudentNumber = 992;
            student2.Name = "Carlos";
            student2.LastName = "Machado";
            student2.Ci = 52848524;
            student2.Coordinates.X = 5;
            student2.Coordinates.Y = 17;
            student2.Subjects.Add(subject3);
            student2.Subjects.Add(subject4);
            studentLogic.Add(student2);

            Student student3 = new Student();
            student3.Id = 993;
            student3.StudentNumber = 993;
            student3.Name = "Lucia";
            student3.LastName = "Matteo";
            student3.Ci = 52724524;
            student3.Coordinates.X = -10;
            student3.Coordinates.Y = 9;
            student3.Subjects.Add(subject2);
            student3.Subjects.Add(subject4);
            studentLogic.Add(student3);


            Student student4 = new Student();
            student4.Id = 9993;
            student4.StudentNumber = 9993;
            student4.Name = "Martin";
            student4.LastName = "Acosta";
            student4.Ci = 52721234;
            student4.Coordinates.X = 50;
            student4.Coordinates.Y = 19;
            student4.Subjects.Add(subject7);
            student4.Subjects.Add(subject1);
            studentLogic.Add(student4);

            Student student5 = new Student();
            student5.Id = 9994;
            student5.StudentNumber = 9994;
            student5.Name = "Diego";
            student5.LastName = "Diaz";
            student5.Ci = 52721234 + 894;
            student5.Coordinates.X = 7;
            student5.Coordinates.Y = -19;
            student5.Subjects.Add(subject6);
            student5.Subjects.Add(subject8);
            studentLogic.Add(student5);

            Student student6 = new Student();
            student6.Id = 8883;
            student6.StudentNumber = 8883;
            student6.Name = "Marcela";
            student6.LastName = "Tonelli";
            student6.Ci = 52721234 - 894;
            student6.Coordinates.X = 0;
            student6.Coordinates.Y = 8;
            student6.Subjects.Add(subject5);
            student6.Subjects.Add(subject6);
            student6.Subjects.Add(subject7);
            student6.Subjects.Add(subject8);
            studentLogic.Add(student6);

            Student student7 = new Student();
            student7.Id = 8884;
            student7.StudentNumber = 8884;
            student7.Name = "Alejandra";
            student7.LastName = "Valverde";
            student7.Ci = 50721234 - 894;
            student7.Coordinates.X = 34;
            student7.Coordinates.Y = -20;
            student7.Subjects.Add(subject2);
            student7.Subjects.Add(subject4);
            student7.Subjects.Add(subject6);
            student7.Subjects.Add(subject8);
            studentLogic.Add(student7);

            TeacherLogic teacherLogic = new TeacherLogic();

            Teacher teacher1 = new Teacher();
            teacher1.Name = "Julio";
            teacher1.LastName = "Matosas";
            teacher1.Id = 971;
            teacher1.Subjects.Add(subject1);

            Teacher teacher2 = new Teacher();
            teacher2.Name = "Pablo";
            teacher2.LastName = "Yañez";
            teacher2.Id = 962;
            teacher2.Subjects.Add(subject3);
            teacher2.Subjects.Add(subject4);

            Teacher teacher3 = new Teacher();
            teacher3.Name = "Romina";
            teacher3.LastName = "Lois";
            teacher3.Id = 994;
            teacher3.Subjects.Add(subject2);

            Teacher teacher4 = new Teacher();
            teacher4.Name = "Santiago";
            teacher4.LastName = "Nogueira";
            teacher4.Id = 445;
            teacher4.Subjects.Add(subject5);
            teacher4.Subjects.Add(subject6);
            teacher4.Subjects.Add(subject7);

            Teacher teacher5 = new Teacher();
            teacher5.Name = "Juan Manuel";
            teacher5.LastName = "Olivera";
            teacher5.Id = 1445;
            teacher5.Subjects.Add(subject4);
            teacher5.Subjects.Add(subject8);

            Teacher teacher6 = new Teacher();
            teacher6.Name = "Maria Noel";
            teacher6.LastName = "Fagundez";
            teacher6.Id = 452;
            teacher6.Subjects.Add(subject5);
            teacher6.Subjects.Add(subject7);
            teacher6.Subjects.Add(subject8);


            teacherLogic.Add(teacher1);
            teacherLogic.Add(teacher2);
            teacherLogic.Add(teacher3);
            teacherLogic.Add(teacher4);
            teacherLogic.Add(teacher5);
            teacherLogic.Add(teacher6);

            SchoolVanLogic schoolVanLogic = new SchoolVanLogic();
            SchoolVan schoolVan1 = new SchoolVan();
            schoolVan1.Id = 901;
            schoolVan1.Capacity = 4;
            schoolVan1.FuelConsumption = 50;
            SchoolVan schoolVan2 = new SchoolVan();
            schoolVan2.Id = 902;
            schoolVan2.Capacity = 1;
            schoolVan2.FuelConsumption = 100;
            SchoolVan schoolVan3 = new SchoolVan();
            schoolVan3.Id = 903;
            schoolVan3.Capacity = 3;
            schoolVan3.FuelConsumption = 35;
            SchoolVan schoolVan4 = new SchoolVan();
            schoolVan4.Id = 904;
            schoolVan4.Capacity = 2;
            schoolVan4.FuelConsumption = 1;
            SchoolVan schoolVan5 = new SchoolVan();
            schoolVan5.Id = 905;
            schoolVan5.Capacity = 5;
            schoolVan5.FuelConsumption = 20;

            schoolVanLogic.Add(schoolVan1);
            schoolVanLogic.Add(schoolVan2);
            schoolVanLogic.Add(schoolVan3);
            schoolVanLogic.Add(schoolVan4);
            schoolVanLogic.Add(schoolVan5);

            Activity newActivity = new Activity();
            newActivity.Date = new DateTime(2017,12,7);
            newActivity.Cost = 400;
            newActivity.Id = 991;
            newActivity.Name = "Campamento";

            Activity newActivity2 = new Activity();
            newActivity2.Date = new DateTime(2018, 2, 17);
            newActivity2.Cost = 400;
            newActivity2.Id = 992;
            newActivity2.Name = "Jornada de Integracion 2018";

            Activity newActivity3 = new Activity();
            newActivity3.Date = new DateTime(2017, 12, 4);
            newActivity3.Cost = 50;
            newActivity3.Id = 993;
            newActivity3.Name = "Visita Libreria de Montevideo";

            Activity newActivity4 = new Activity();
            newActivity4.Date = new DateTime(2017, 12, 2);
            newActivity4.Cost = 150;
            newActivity4.Id = 994;
            newActivity4.Name = "Entrenamiento Futbol";
            ActivityLogic activityLogic = new ActivityLogic();

            activityLogic.Add(newActivity);
            activityLogic.Add(newActivity2);
            activityLogic.Add(newActivity3);
            activityLogic.Add(newActivity4);
            ActivityPaymentLogic activityPaymentLogic = new ActivityPaymentLogic();
            SubscriptionLogic subscriptionLogic = new SubscriptionLogic();
            List<Student> allStudents = studentLogic.GetAllStudents();
            foreach (Student item in allStudents)
            {
                List<Activity> allActivities = activityLogic.GetAllActivities();
                Random random = new Random();
                int randomActivity = random.Next(0, allActivities.Count-1);
                ActivityPayment newActivityPayment = new ActivityPayment();
                newActivityPayment.Activity = allActivities.ElementAt(randomActivity);
                newActivityPayment.Student = item;
                activityPaymentLogic.Add(newActivityPayment);
               
                int randomMonths = random.Next(0, 4);
                for (int i = 0; i < randomMonths; i++)
                {
                    DateTime newDate = new DateTime(2017,11,5);
                    newDate=newDate.AddMonths(i);
                    Subscription newSubscription = new Subscription();
                    newSubscription.Student = item;
                    newSubscription.Date = newDate;
                    subscriptionLogic.Add(newSubscription);
                }
            }
        }
    }
}
