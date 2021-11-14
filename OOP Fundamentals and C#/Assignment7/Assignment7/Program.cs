using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student> { 
                new Student("John", "Smith", 21, "USA"), 
                new Student("Maria", "Garcia", 23, "Spain"),
                new Student("Bjorn", "Bjornsson", 21, "Norway"),
                new Student("Xin","Lin",20,"China"),
                new Student("Frigga", "Ragnarsdatter",22,"Norway"),
                new Student("Francois", "Monet",23,"France"),
                new Student("Rami", "Reddy",21,"India")
            };

            var filterByCountry = students.Where(x => x.Country.Equals("Norway"));

            foreach (var f in filterByCountry)
            {
                Console.WriteLine(f.ToString());
            }

            var filterByAge = from s in students orderby s.Age descending group s.LastName by s.Age; 

            foreach(var f in filterByAge)
            {
                Console.WriteLine(String.Format("Age: {0,-10}Count: {1}",f.Key,f.Count()));
                foreach(var i in f)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
            }
        }

    }
}
