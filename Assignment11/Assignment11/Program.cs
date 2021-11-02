using Assignment11.Composite;
using Assignment11.Proxy;
using System;

namespace Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Proxy
            IUser user = new UserProxy("user");
            IUser admin = new UserProxy("admin");

            Console.WriteLine(user.CreateProfile());
            Console.WriteLine(user.NotifyCompany());

            //Composite
            Company company = new Company();

            company.AddPerson(new Candidate("Bob", "bob@gmail.com", "Rejected"));
            company.AddPerson(new Candidate("Andrew", "andrew@gmail.com", "Hired"));
            company.AddPerson(new Composite.User("user1", "user@gmial.com"));
            company.AddPerson(new Admin("admin", "admin@gmial.com"));

            company.DisplayEntityDetails();
        }
    }
}
