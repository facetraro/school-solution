using Domain;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class StudentAccess
    {
        public void Add(Student student)
        {
            using (var context = new ContextDB())
            {
                try
                {
                    foreach (Subject actualSubject in student.Subjects)
                    {
                        context.Subjects.Attach(actualSubject);
                    }
                    context.Students.Add(student);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw new StudentPersistanceException("Estudiante ya ingresado en el sistema.");
                }
            }
        }
        public void Empty()
        {
            try
            {
                using (var context = new ContextDB())
                {
                    List<Student> students = context.Students.ToList();
                    foreach (Student actual in students)
                    {
                        Student toDelete = context.Students.Find(actual.Id);
                        context.Students.Remove(toDelete);
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new StudentPersistanceException("Error en la base de datos. Imposible vaciar valores de estudiante.");
            }
        }
    }
}
