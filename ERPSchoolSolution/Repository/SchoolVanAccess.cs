using Domain;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SchoolVanAccess
    {
        public void Add(SchoolVan schoolVan)
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
                    throw new StudentPersistanceException("Camioneta ya ingresada en el sistema.");
                }
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
                throw new StudentPersistanceException("Error en la base de datos. Imposible vaciar valores de camionetas.");
            }
        }
    }
}
