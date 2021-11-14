using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class People : IEnumerable
    {
        private List<Person> _people;

        public People(List<Person> peopleArr)
        {
            _people = new List<Person>();
            peopleArr.ForEach(p => _people.Add(p));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(_people);
        }
    }
}
