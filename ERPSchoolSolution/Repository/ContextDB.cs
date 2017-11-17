using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ContextDB : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<SchoolVan> SchoolVans { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<ActivityPayment> ActivityPayments { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(Student => Student.Id);
            modelBuilder.Entity<SchoolVan>().HasKey(SchoolVan => SchoolVan.Id);
            modelBuilder.Entity<Subject>().HasKey(Subject => Subject.Code);
            modelBuilder.Entity<Teacher>().HasKey(Teacher => Teacher.Id);
            modelBuilder.Entity<ActivityPayment>().HasKey(ActivityPayment => ActivityPayment.Id);

        }  
    }
}
