using Assignment10.Observer;
using System;

namespace Assignment10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Observer
            Company company = new Company("Canon");
            company.AddUser(new User("user"));
            company.AddUser(new User("admin"));
            company.CreatePosition();
        }
    }
}
