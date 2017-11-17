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
    public class SchoolVanAccess : ARMEAccess
    {
        public void Add(object anObject)
        {
            SchoolVan schoolVan = anObject as SchoolVan;
            AddSchoolVan(schoolVan);
        }
        public void Modify(object modifiedObject)
        {
            SchoolVan schoolVan = modifiedObject as SchoolVan;
            RemoveSchoolVan(schoolVan);
        }

        public void Remove(object anObject)
        {
            SchoolVan schoolVan = anObject as SchoolVan;
            RemoveSchoolVan(schoolVan);
        }
        public SchoolVan Get(int id)
        {
            try
            {
                using (var context = new ContextDB())
                {
                    SchoolVan schoolVanToFind = context.SchoolVans.Find(id);
                    return schoolVanToFind;
                }
            }
            catch (Exception)
            {
                throw new SchoolVanPersistanceException("Se ha perdido la conexion con el servidor");
            }
        }
        public List<SchoolVan> GetAllLazyLoading()
        {
            List<SchoolVan> allSchoolVans = new List<SchoolVan>();
            try
            {
                using (var context = new ContextDB())
                {
                    allSchoolVans = context.SchoolVans.ToList();
                }
            }
            catch (Exception)
            {
                throw new SchoolVanPersistanceException("Se ha perdido la conexion con el servidor");
            }
            return allSchoolVans;
        }
        public List<SchoolVan> GetAll()
        {
            List<SchoolVan> lazyLoading = GetAllLazyLoading();
            List<SchoolVan> allSchoolVans = new List<SchoolVan>();
            foreach (SchoolVan item in lazyLoading)
            {
                allSchoolVans.Add(Get(item.Id));
            }
            return allSchoolVans;
        }
        private void AddSchoolVan(SchoolVan schoolVan)
        {
            using (var context = new ContextDB())
            {
                try
                {
                    context.SchoolVans.Add(schoolVan);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw new SchoolVanPersistanceException("Camioneta ya ingresada en el sistema.");
                }
            }
        }
        public void RemoveSchoolVan(SchoolVan aSchoolVan)
        {
            try
            {
                using (var context = new ContextDB())
                {
                    context.SchoolVans.Attach(aSchoolVan);
                    context.SchoolVans.Remove(aSchoolVan);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new SchoolVanPersistanceException("Se ha perdido la conexion con el servidor");
            }
        }
        private void ModifySchoolVan(SchoolVan modifiedSchoolVan)
        {
            try
            {
                using (var context = new ContextDB())
                {
                    SchoolVan oldSchoolVan = Get(modifiedSchoolVan.Id);
                    context.SchoolVans.Attach(oldSchoolVan);
                    oldSchoolVan.Capacity = modifiedSchoolVan.Capacity;
                    context.Entry(oldSchoolVan).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new SchoolVanPersistanceException("Se ha perdido la conexion con el servidor");
            }
        }
        public void Empty()
        {
            try
            {
                using (var context = new ContextDB())
                {
                    List<SchoolVan> schoolVans = context.SchoolVans.ToList();
                    foreach (SchoolVan actual in schoolVans)
                    {
                        SchoolVan toDelete = context.SchoolVans.Find(actual.Id);
                        context.SchoolVans.Remove(toDelete);
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new SchoolVanPersistanceException("Error en la base de datos. Imposible vaciar valores de camionetas.");
            }
        }
    }
}
