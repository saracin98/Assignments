using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class PeopleEnum : IEnumerator
    {
        public List<Person> _people;

        int position = -1;

        public PeopleEnum(List<Person> list)
        {
            _people = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _people.Count());
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Person Current
        {
            get
            {
                try
                {
                    return _people[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}