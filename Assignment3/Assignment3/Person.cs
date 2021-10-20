using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    abstract class Person :ICloneable
    {
        private string Name;
        private int Age;

        public string GetName()
        {
            return Name;
        }

        public int GetAge()
        {
            return Age;
        }

        public void SetName(string name)
        {
            Name = name;
        }
        public void SetAge(int age)
        {
            Age = age;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void Heal();

        public object Clone()
        {
           return MemberwiseClone();
        }
    }
}
