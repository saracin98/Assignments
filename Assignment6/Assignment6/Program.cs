using System;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            Company<Employee> company1 = new Company<Employee>(new Employee[] { new Employee("Jhon"), new Employee("Bob") });
            Company<Employee> company2 = new Company<Employee>(new Employee[] { new Employee("Jhon"), new Employee("Bob") });

            company1.SwapPosition(0, 1);
            company1.SetEntity(1, new Employee("Mary"));

            Console.WriteLine(company1.GetEntity(0).Name);
            Console.WriteLine(company1.GetEntity(1).Name);

            //Equality compariosn

            Console.WriteLine(company1.Equals(company2));
            Console.WriteLine(company1 == company2);

            //Convariance 

            IPerson<Employee> employee1 = new Person<Employee>();
            IPerson<Developer> developer1 = new Person<Developer>();

            Covariant(employee1);
            Covariant(developer1);

            //Contravariance
            IUser<Employee> employee2 = new User<Employee>();
            IUser<Developer> developer2 = new User<Developer>();

            Contravariance(employee2);
            Contravariance(developer2);
        }

        public static void Covariant(IPerson<Employee> employee)
        {

        }

        public static void Contravariance(IUser<Developer> developer)
        {

        }
    }
}
