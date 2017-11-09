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
                    throw new StudentPersistanceException("Se ha perdido la conexion con el servidor");
                }
            }
        }
        public Student Get(int id)
        {
            try
            {
                using (var context = new ContextDB())
                {
                    Student studentToFind = context.Students.Find(id);
                    context.Students.Include(d => d.Subjects).ToList();
                    return studentToFind;
                }
            }
            catch (Exception)
            {
                throw new StudentPersistanceException("Se ha perdido la conexion con el servidor");
            }
        }
        public List<Student> GetAllLazyLoading()
        {
            List<Student> allStudents = new List<Student>();
            try
            {
                using (var context = new ContextDB())
                {
                    allStudents = context.Students.ToList();
                }
            }
            catch (Exception)
            {
                throw new StudentPersistanceException("Se ha perdido la conexion con el servidor");
            }
            return allStudents;
        }
        public List<Student> GetAll()
        {
            List<Student> lazyLoading = GetAllLazyLoading();
            List<Student> allStudents = new List<Student>();
            foreach (Student item in lazyLoading)
            {
                allStudents.Add(Get(item.Id));
            }
            return allStudents;
        }
        public void Remove(Student student)
        {
            try
            {
                using (var context = new ContextDB())
                {
                    context.Students.Attach(student);
                    context.Students.Remove(student);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new StudentPersistanceException("Se ha perdido la conexion con el servidor");
            }
        }
        public void Modify(Student originalStudent, Student modifiedStudent)
        {
            try
            {
                using (var context = new ContextDB())
                {
                    // Paso 2 objetos
                    context.Students.Attach(originalStudent);
                    originalStudent.Name = modifiedStudent.Name;
                    originalStudent.LastName = modifiedStudent.LastName;
                    originalStudent.Coordinates = modifiedStudent.Coordinates;
                    originalStudent.Ci = modifiedStudent.Ci;
                    originalStudent.Subjects = modifiedStudent.Subjects;
                    context.Entry(originalStudent).State = EntityState.Modified;

                    // Paso 1 objeto
                    context.Students.Attach(modifiedStudent);
                    context.Entry(originalStudent).State = EntityState.Modified;

                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new StudentPersistanceException("Se ha perdido la conexion con el servidor");
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
                throw new StudentPersistanceException("Se ha perdido la conexion con el servidor");
            }
        }
    }
}
