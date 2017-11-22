using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSchoolValidator
{
    public class SchoolVan
    {
        private int id;
        private int capacity;
        private int fuelConsumption;
        public SchoolVan()
        {
            this.Id = 0;
            this.fuelConsumption = 1;
            this.Capacity = 1;
        }
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public int FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                this.fuelConsumption = value;
            }
        }
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                this.capacity = value;
            }
        }
        
        public override bool Equals(object aSchoolVan)
        {
            SchoolVan theSchoolVan = aSchoolVan as SchoolVan;
            if ((System.Object)theSchoolVan == null)
            {
                return false;
            }
            return (this.Id == theSchoolVan.Id);
        }
        public override string ToString()
        {
            return "[" + id + "] Capacidad " + capacity + " - Consumo " + fuelConsumption;
        }
    }
}
