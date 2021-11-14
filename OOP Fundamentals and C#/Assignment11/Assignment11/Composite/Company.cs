using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11.Composite
{
    class Company : IEntity
    {
        private List<IEntity> Persons;

        public Company()
        {
            Persons = new List<IEntity>();
        }

        public void AddPerson(IEntity person)
        {
            Persons.Add(person);
        }

        public void DisplayEntityDetails()
        {
            Persons.ForEach(p => p.DisplayEntityDetails());
        }
    }
}
