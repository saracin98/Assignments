using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.FactoryMethod
{
    class User:IPerson
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public void SendResume()
        {
            Console.WriteLine($"{Name} sent Resume to company");
        }

        public User(string name,string email)
        {
            Name = name;
            Email = email;
        }
    }
}
