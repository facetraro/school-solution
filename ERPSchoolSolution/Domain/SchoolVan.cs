using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SchoolVan
    {
        private int id;
        private int capacity;
        private static int MAX_CAPACITY = 15;
        private static int MIN_CAPACITY = 1;
        public SchoolVan()
        {
            this.Id = 0;
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
        private bool validCapacity()
        {
            return (this.capacity >= MIN_CAPACITY && this.capacity <= MAX_CAPACITY);
        }
        public bool IsValid()
        {
            return validCapacity();
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
    }
}
