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
            IPerson candidate1 = new Candidate("Bob", "bob@gmail.com", "Rejected");
            IPerson candidate2 = new Candidate("Andrew", "andrew@gmail.com", "Hired");
            IPerson employee = new Employee("user1", "user@gmial.com");

            company.AddPerson(candidate1);
            company.AddPerson(candidate2);
            company.AddPerson(employee);

            company.DisplayPersonDetails();
        }
    }
}
