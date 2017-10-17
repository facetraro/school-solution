using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SchoolVanValidator : IValidator
    {
        private static int max_capacity = 15;
        private static int min_capacity = 1;
        private static int min_id = 0;
        private bool ValidCapacity(SchoolVan aSchoolVan)
        {
            if (!(aSchoolVan.Capacity >= min_capacity && aSchoolVan.Capacity <= max_capacity))
            {
                throw new InvalidValueException("La camioneta debe tener la capacidad entre ["+ min_capacity + "-"+ max_capacity + "]");
            }
            return true;
        }
        private bool ValidId(SchoolVan aSchoolVan)
        {
            if (aSchoolVan.Id < min_id)
            {
                throw new EmptyOrNullValueException("El id debe ser mayor a "+min_id);
            }
            return true;
        }
        private bool AllAtributesAreValid(SchoolVan theSchoolVan)
        {
            bool capacityValidation = ValidCapacity(theSchoolVan);
            bool idValidation = ValidId(theSchoolVan);
            return (capacityValidation && idValidation);
        }
        public bool IsValid(object anObject)
        {
            SchoolVan theSchoolVan = anObject as SchoolVan;
            if ((System.Object)theSchoolVan == null)
            {
                throw new InvalidObjectAddIntoSchoolVanException("Se esperaba un objeto del tipo [SchoolVan]");
            }
            return AllAtributesAreValid(theSchoolVan);
        }
    }
}
