using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Mechanic : Person
    {
        private int Experience;

        public int GetExperience()
        {
            return Experience;
        }
        public void SetExperience(int experience)
        {
            Experience=experience;
        }
        public Mechanic(string name, int age, int experience) : base(name, age)
        {
            Experience = experience;
        }

        //Create a method and make its overloaded and overridden versions
        public void FixCar(string carName)
        {
            Console.WriteLine($"{carName} is fixed!");
        }

        public void FixCar(string carName, string spareParts)
        {
            Console.WriteLine($"{carName} fixed with {spareParts}");
        }

        public override void Heal()
        {
            Console.WriteLine($"Mechanic is healed");
        }
    }
}
