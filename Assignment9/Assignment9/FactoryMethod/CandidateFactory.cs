using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.FactoryMethod
{
    class CandidateFactory : IPersonFactory
    {
        public IPerson CreatePerson(string name, string email)
        {
            return new Candidate(name,email);
        }
    }
}
