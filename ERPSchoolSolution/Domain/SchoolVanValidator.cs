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
        private static int MAX_CAPACITY = 15;
        private static int MIN_CAPACITY = 1;
        private static int MIN_ID = 0;
        private bool ValidCapacity(SchoolVan aSchoolVan)
        {
            if (!(aSchoolVan.Capacity >= MIN_CAPACITY && aSchoolVan.Capacity <= MAX_CAPACITY))
            {
                throw new InvalidValueException("La camioneta debe tener la capacidad entre ["+MIN_CAPACITY+"-"+MAX_CAPACITY+"]");
            }
            return true;
        }
        private bool ValidId(SchoolVan aSchoolVan)
        {
            if (aSchoolVan.Id < MIN_ID)
            {
                throw new EmptyOrNullValueException("El id debe ser mayor a 0");
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
