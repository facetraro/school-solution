using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSchoolValidator
{
    public class SchoolVanValidator : IValidator
    {
        private static int max_capacity = 15;
        private static int min_capacity = 1;
        private static int min_id = 0;
        private static int min_fuelConsumption = 0;
        private bool ValidCapacity(SchoolVan aSchoolVan)
        {
            bool validationCapacity = true;
            if (!(aSchoolVan.Capacity >= min_capacity && aSchoolVan.Capacity <= max_capacity))
            {
                validationCapacity = false;
            }
            return validationCapacity;
        }
        private bool ValidFuelConsumption(SchoolVan aSchoolVan)
        {
            bool fuelValidation = true;
            if (aSchoolVan.FuelConsumption <= min_fuelConsumption)
            {
                fuelValidation = false;
            }
            return fuelValidation;
        }
        private bool ValidId(SchoolVan aSchoolVan)
        {
            bool validationId = true;
            if (aSchoolVan.Id < min_id)
            {
                validationId = false;
            }
            return validationId;
        }
        private bool AllAtributesAreValid(SchoolVan theSchoolVan)
        {
            bool capacityValidation = ValidCapacity(theSchoolVan);
            if (!capacityValidation)
            {
                throw new InvalidValueException("La camioneta debe tener la capacidad entre [" + min_capacity + "-" + max_capacity + "]");
            }
            bool idValidation = ValidId(theSchoolVan);
            if (!idValidation)
            {
                throw new EmptyOrNullValueException("El id debe ser mayor a " + min_id);
            }
            bool fuelConsumptionValidation = ValidFuelConsumption(theSchoolVan);
            if (!fuelConsumptionValidation)
            {
                throw new InvalidValueException("La camioneta debe tener un consumo mayor a " + min_fuelConsumption);
            }
            return (capacityValidation && idValidation && fuelConsumptionValidation);
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
