using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10.Observer
{
    class User : IUser
    {
        public string Username { get; set; }

        public User(string username)
        {
            Username = username;
        }
        public void Update(ICompany company)
        {
            Console.WriteLine($"{Username} notified: {company.Name} released a new Position");
        }
    }
}
