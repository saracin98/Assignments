using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11.Composite
{
    class Company : IPerson
    {
        private List<IPerson> Persons;

        public Company()
        {
            Persons = new List<IPerson>();
        }

        public void AddPerson(IPerson person)
        {
            Persons.Add(person);
        }

        public void DisplayPersonDetails()
        {
            Persons.ForEach(p => p.DisplayPersonDetails());
        }
    }
}
