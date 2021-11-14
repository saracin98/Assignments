using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10.Observer
{
    class Company : ICompany
    {
        public string Name { get; set; }
        private List<IUser> _users = new List<IUser>();
        public Company(string name)
        {
            Name = name;
        }
        public void AddUser(IUser user)
        {
            _users.Add(user);
        }

        public void Notify()
        {
            _users.ForEach(u => u.Update(this));
        }

        public void CreatePosition()
        {
            Console.WriteLine("A new position has been released!");
            Notify();
        }
    }
}
