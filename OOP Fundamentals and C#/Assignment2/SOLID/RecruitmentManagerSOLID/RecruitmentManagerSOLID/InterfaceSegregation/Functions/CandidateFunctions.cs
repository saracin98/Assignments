using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagerSOLID.InterfaceSegregation
{
    class CandidateFunctions : IPerson
    {
        public void SendDesiredSalary()
        {
            Console.WriteLine("Desired salary has been sent");
        }

        public void SendJobDescription()
        {
            throw new NotImplementedException();
        }
    }
}
