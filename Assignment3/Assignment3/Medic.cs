using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Medic : Person
    {
        public string Grade { get; set; }

        public override void Heal()
        {
            Console.WriteLine("Medic is healed!");
        }

        public Medic(string name, int age,string grade) : base(name,age)
        {
            Grade = grade;
        }
    }
}
