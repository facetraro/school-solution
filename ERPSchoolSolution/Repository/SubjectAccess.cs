using Domain;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SubjectAccess : ARMEAccess
    {
        public void Add(object anObject)
        {
            Subject subject = anObject as Subject;
            AddSubject(subject);
        }

        public void Remove(object anObject)
        {
            Subject subject = anObject as Subject;
            RemoveSubject(subject);
        }
        public void Modify(object modifiedObject)
        {
            Subject subject = modifiedObject as Subject;
            ModifySubject(subject);
        }
        public void AddSubject(Subject subject)
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
                    throw new SubjectPersistanceException("Se ha perdido la conexion con el servidor");
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
                throw new SubjectPersistanceException("Se ha perdido la conexion con el servidor");
            }
        }
        public Subject Get(string id)
        {
            try
            {
                using (var context = new ContextDB())
                {
                    Subject subjectToFind = context.Subjects.Find(id);
                    context.Subjects.Include(d => d.Students).ToList();
                    context.Subjects.Include(d => d.Teachers).ToList();
                    return subjectToFind;
                }
            }
            catch (Exception)
            {
                throw new SubjectPersistanceException("Se ha perdido la conexion con el servidor");
            }
        }
        public List<Subject> GetAllLazyLoading()
        {
            List<Subject> allSubjects = new List<Subject>();
            try
            {
                using (var context = new ContextDB())
                {
                    allSubjects = context.Subjects.ToList();
                }
            }
            catch (Exception)
            {
                throw new SubjectPersistanceException("Se ha perdido la conexion con el servidor");
            }
            return allSubjects;
        }
        public List<Subject> GetAll()
        {
            List<Subject> lazyLoading = GetAllLazyLoading();
            List<Subject> allSubjects = new List<Subject>();
            foreach (Subject item in lazyLoading)
            {
                allSubjects.Add(Get(item.Code));
            }
            return allSubjects;
        }
        public void RemoveSubject(Subject subject)
        {
            try
            {
                using (var context = new ContextDB())
                {
                    context.Subjects.Attach(subject);
                    context.Subjects.Remove(subject);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new SubjectPersistanceException("Se ha perdido la conexion con el servidor");
            }
        }
        public void ModifySubject(Subject modifiedSubject)
        {
            try
            {
                using (var context = new ContextDB())
                {
                    context.Subjects.Attach(modifiedSubject);
                    context.Entry(modifiedSubject).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new SubjectPersistanceException("Se ha perdido la conexion con el servidor");
            }
        }
    }
}
