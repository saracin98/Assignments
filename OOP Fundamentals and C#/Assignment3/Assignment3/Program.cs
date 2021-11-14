using System;
using System.Collections.Generic;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Mechanic mechanic1 = new Mechanic("Bob", 50, 16);
            Mechanic mechanic2 = new Mechanic("Alex", 35, 10);
            Medic medic1 = new Medic("Jhon", 40, "Specialist");
            Medic medic2 = new Medic("Mary", 26, "Resident");

            mechanic1.FixCar("Toyota");
            mechanic2.FixCar("Nissan", "gearbox");

            medic1.Heal();
            Console.WriteLine(medic2.Grade);

            People people = new People(new List<Person>() { mechanic1, mechanic2, medic1, medic2 });

            foreach (var p in people)
            {
                Console.WriteLine(p.GetName());
            }

            Medic medic3 = medic2.Clone() as Medic;

            Console.WriteLine(medic3.GetName());
        }
    }
}
