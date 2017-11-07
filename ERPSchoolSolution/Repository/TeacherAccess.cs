using Domain;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TeacherAccess
    {
        public void Add(Teacher teacher)
        {
            using (var context = new ContextDB())
            {
                try
                {
                    foreach (Subject actualSubject in teacher.Subjects)
                    {
                        context.Subjects.Attach(actualSubject);
                    }
                    context.Teachers.Add(teacher);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw new StudentPersistanceException("Docente ya ingresado en el sistema.");
                }
            }
        }
        public void Empty()
        {
            try
            {
                using (var context = new ContextDB())
                {
                    List<Teacher> teachers = context.Teachers.ToList();
                    foreach (Teacher actual in teachers)
                    {
                        Student toDelete = context.Students.Find(actual.Id);
                        context.Students.Remove(toDelete);
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new StudentPersistanceException("Error en la base de datos. Imposible vaciar valores de Docente.");
            }
        }
    }
}
