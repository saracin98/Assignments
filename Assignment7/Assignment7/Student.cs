using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public Student(string firstName, string lastName, int age, string country)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Country = country;
        }

        public string ToString()
        {
            return $"First Name: {FirstName},\nLast Name: {LastName},\nAge: {Age},\nCountry: {Country}\n";
        }
    }
}
