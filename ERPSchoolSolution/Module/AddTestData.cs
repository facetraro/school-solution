using Domain;
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
            SubjectLogic subjectLogic = new SubjectLogic();
            subjectLogic.Add(subject1);
            subjectLogic.Add(subject2);
            subjectLogic.Add(subject3);
            subjectLogic.Add(subject4);

            StudentLogic studentLogic = new StudentLogic();

            Student student1 = new Student();
            student1.Id = 1;
            student1.StudentNumber = 1;
            student1.Name = "Juan";
            student1.LastName = "Rodriguez";
            student1.Ci = 46702345;
            student1.Coordinates.X = 24;
            student1.Coordinates.Y = -9;
            student1.Subjects.Add(subject1);
            student1.Subjects.Add(subject2);
            studentLogic.Add(student1);

            Student student2 = new Student();
            student2.Id = 3;
            student2.StudentNumber = 3;
            student2.Name = "Carlos";
            student2.LastName = "Machado";
            student2.Ci = 52848524;
            student2.Coordinates.X = 5;
            student2.Coordinates.Y = 17;
            student2.Subjects.Add(subject3);
            student2.Subjects.Add(subject4);
            studentLogic.Add(student2);

            Student student3 = new Student();
            student3.Id = 8;
            student3.StudentNumber = 8;
            student3.Name = "Lucia";
            student3.LastName = "Matteo";
            student3.Ci = 52724524;
            student3.Coordinates.X = -10;
            student3.Coordinates.Y = 9;
            student3.Subjects.Add(subject2);
            student3.Subjects.Add(subject4);
            studentLogic.Add(student3);

            TeacherLogic teacherLogic = new TeacherLogic();

            Teacher teacher1 = new Teacher();
            teacher1.Name = "Julio";
            teacher1.LastName = "Matosas";
            teacher1.Id = 1;
            teacher1.Subjects.Add(subject1);

            Teacher teacher2 = new Teacher();
            teacher2.Name = "Pablo";
            teacher2.LastName = "Yañez";
            teacher2.Id = 2;
            teacher2.Subjects.Add(subject3);
            teacher2.Subjects.Add(subject4);

            Teacher teacher3 = new Teacher();
            teacher3.Name = "Romina";
            teacher3.LastName = "Lois";
            teacher3.Id = 4;
            teacher3.Subjects.Add(subject2);

            teacherLogic.Add(teacher1);
            teacherLogic.Add(teacher2);
            teacherLogic.Add(teacher3);


            SchoolVanLogic schoolVanLogic = new SchoolVanLogic();
            SchoolVan schoolVan1 = new SchoolVan();
            schoolVan1.Id = 1;
            schoolVan1.Capacity = 4;
            SchoolVan schoolVan2 = new SchoolVan();
            schoolVan2.Id = 2;
            schoolVan2.Capacity = 10;

            schoolVanLogic.Add(schoolVan1);
            schoolVanLogic.Add(schoolVan2);
        }
    }
}
