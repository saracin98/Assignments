using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11.Composite
{
    class Employee : IPerson
    {
        private string Name;
        private string Email;

        public Employee(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public void DisplayPersonDetails()
        {
            Console.WriteLine($"Name: {Name},\nEmail:{Email}\n");
        }
    }
}
