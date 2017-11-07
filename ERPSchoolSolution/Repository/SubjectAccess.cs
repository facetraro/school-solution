using Domain;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SubjectAccess
    {
        public void Add(Subject subject)
        {
            using (var context = new ContextDB())
            {
                try
                {
                    foreach (Student actualStudent in subject.Students)
                    {
                        context.Students.Attach(actualStudent);
                    }
                    foreach (Teacher actualTeacher in subject.Teachers)
                    {
                        context.Teachers.Attach(actualTeacher);
                    }
                    context.Subjects.Add(subject);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw new StudentPersistanceException("Materia ya ingresada en el sistema.");
                }
            }
        }
        public void Empty()
        {
            try
            {
                using (var context = new ContextDB())
                {
                    List<Subject> subjects = context.Subjects.ToList();
                    foreach (Subject actual in subjects)
                    {
                        Subject toDelete = context.Subjects.Find(actual.Code);
                        context.Subjects.Remove(toDelete);
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new StudentPersistanceException("Error en la base de datos. Imposible vaciar valores de materia.");
            }
        }
    }
}
