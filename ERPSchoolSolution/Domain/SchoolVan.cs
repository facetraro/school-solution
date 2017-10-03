﻿using System;
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
        public SchoolVan()
        {
            this.Id = 0;
            this.Capacity = 1;
        }
        public SchoolVan(int id, int capacity)
        {
            this.Id = id;
            this.Capacity = capacity;
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
        public bool IsValid()
        {
            return (this.capacity>=1 && this.capacity<=15);
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
