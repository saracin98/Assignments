using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11.Composite
{
    public class Candidate : IEntity
    {
        private string Name;
        private string Email;
        private string Status;

        public Candidate(string name, string email, string status)
        {
            Name = name;
            Email = email;
            Status = status;
        }

        public void DisplayEntityDetails()
        {
            Console.WriteLine($"Name: {Name,-10}{Status}\nEmail:{Email}\n");
        }
    }
}
