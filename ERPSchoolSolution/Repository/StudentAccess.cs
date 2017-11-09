﻿using Domain;
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
                    student.Subjects = GetSubjectListAttached(context, student);
                    context.Students.Add(student);
                    context.SaveChanges();
                }
                catch (Exception e)
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
        /*
        public void updateSubjects(Student modifiedStudent, List<Subject> list)
        {
            try
            {
                using (var context = new ContextDB())
                {
                    Student oldStudent = Get(modifiedStudent.Id);
                    oldStudent.Subjects = new List<Subject>();
                    context.Database.ExecuteSqlCommand("DELETE FROM SubjectStudents WHERE Student_Id = " + modifiedStudent.Id);
                    foreach (Subject actual in list)
                    {
                        string query= "INSERT INTO SubjectStudents(Student_Id, Subject_Code) VALUES  (" + modifiedStudent.Id + ", '" + actual.Code + "')";
                        context.Database.ExecuteSqlCommand(query);
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new StudentPersistanceException("Error en la base de datos. Imposible Modificar el Equipo ");
            }
        }
        */
        private List<Subject> GetSubjectListAttached(ContextDB context, Student modifiedStudent)
        {
            List<Subject> listOfSubjects = new List<Subject>();
            foreach (Subject actualSubject in modifiedStudent.Subjects)
            {
                listOfSubjects.Add(context.Subjects.Where(b => b.Code == actualSubject.Code).Include(b => b.Students).FirstOrDefault());
            }
            return listOfSubjects;
        }
        public void Modify(Student modifiedStudent)
        {
            try
            {
                using (var context = new ContextDB())
                {
                    Student oldStudent = Get(modifiedStudent.Id);
                    context.Students.Attach(oldStudent);
                    oldStudent.Name = modifiedStudent.Name;
                    oldStudent.LastName = modifiedStudent.LastName;
                    oldStudent.StudentNumber = modifiedStudent.StudentNumber;
                    oldStudent.Coordinates = modifiedStudent.Coordinates;
                    oldStudent.Ci = modifiedStudent.Ci;
                    oldStudent.Subjects = modifiedStudent.Subjects;
                    
                    oldStudent.Subjects = GetSubjectListAttached(context,modifiedStudent);
                    context.Entry(oldStudent).State = EntityState.Modified;
                    context.SaveChanges();

                }
            }
            catch (Exception e)
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
