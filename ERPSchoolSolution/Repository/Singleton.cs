using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Singleton
    {
        private static Singleton instance;
        public List<SchoolVan> SchoolVans { get; set; }
        public List<Student> Students { get; set; }

        private Singleton()
        {
            this.SchoolVans = new List<SchoolVan>();
            this.Students = new List<Student>();
        }
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
