using Domain;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Repository
{
    public class TeacherAccess : ARMEAccess
    {
        public void Add(object anObject)
        {
            Teacher teacher = anObject as Teacher;
            AddTeacher(teacher);
        }
        public void Modify(object modifiedObject)
        {
            Teacher teacher = modifiedObject as Teacher;
            ModifyTeacher(teacher);
        }
        public void Remove(object modifiedObject)
        {
            Teacher teacher = modifiedObject as Teacher;
            RemoveTeacher(teacher);
        }
        public void AddTeacher(Teacher teacher)
        {
            using (var context = new ContextDB())
            {
                try
                {
                    teacher.Subjects = GetSubjectListAttached(context, teacher);
                    context.Teachers.Add(teacher);
                    context.SaveChanges();
                }


                catch (Exception)
                {
                    throw new StudentPersistanceException("Docente ya ingresado en el sistema.");
                }
            }
        }
        private List<Subject> GetSubjectListAttached(ContextDB context, Teacher modifiedTeacher)
        {
            List<Subject> listOfSubjects = new List<Subject>();
            foreach (Subject actualSubject in modifiedTeacher.Subjects)
            {
                listOfSubjects.Add(context.Subjects.Where(b => b.Code == actualSubject.Code).Include(b => b.Students).FirstOrDefault());
            }
            return listOfSubjects;
        }
        public void RemoveTeacher(Teacher teacher)
        {
            try
            {
                using (var context = new ContextDB())
                {
                    context.Teachers.Attach(teacher);
                    context.Teachers.Remove(teacher);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new StudentPersistanceException("Se ha perdido la conexion con el servidor");
            }
        }

        public List<Teacher> GetAllLazyLoading()
        {
            List<Teacher> allTeachers = new List<Teacher>();
            try
            {
                using (var context = new ContextDB())
                {
                    allTeachers = context.Teachers.ToList();
                }
            }
            catch (Exception)
            {
                throw new StudentPersistanceException("Se ha perdido la conexion con el servidor");
            }
            return allTeachers;
        }
        public Teacher Get(int id)
        {
            try
            {
                using (var context = new ContextDB())
                {
                    Teacher teacherToFind = context.Teachers.Find(id);
                    context.Teachers.Include(d => d.Subjects).ToList();
                    return teacherToFind;
                }
            }
            catch (Exception)
            {
                throw new StudentPersistanceException("Se ha perdido la conexion con el servidor");
            }
        }
        public List<Teacher> GetAll()
        {
            List<Teacher> lazyLoading = GetAllLazyLoading();
            List<Teacher> allTeachers = new List<Teacher>();
            foreach (Teacher item in lazyLoading)
            {
                allTeachers.Add(Get(item.Id));
            }
            return allTeachers;
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
                        Teacher toDelete = context.Teachers.Find(actual.Id);
                        context.Teachers.Remove(toDelete);
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new StudentPersistanceException("Error en la base de datos. Imposible vaciar valores de Docente.");
            }
        }

        public void ModifyTeacher(Teacher modifiedTeacher)
        {
            try
            {
                using (var context = new ContextDB())
                {
                    Teacher oldTeacher = Get(modifiedTeacher.Id);
                    context.Teachers.Attach(oldTeacher);
                    oldTeacher.Id = modifiedTeacher.Id;
                    oldTeacher.Name = modifiedTeacher.Name;
                    oldTeacher.LastName = modifiedTeacher.LastName;
                    oldTeacher.Subjects = modifiedTeacher.Subjects;
                    oldTeacher.Subjects = GetSubjectListAttached(context, modifiedTeacher);
                    context.Entry(oldTeacher).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                throw new StudentPersistanceException("Se ha perdido la conexion con el servidor");
            }
        }
    }
}
