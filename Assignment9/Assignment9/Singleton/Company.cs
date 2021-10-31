using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Singleton
{
    class Company
    {
        public static Company _instance = null;
        public String Name { get; set; }

        private Company()
        {
            Console.WriteLine("Company was created");
        }

        public static Company Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Company();
                }
                return _instance;
            }
            private set { }
        }
    }
}
