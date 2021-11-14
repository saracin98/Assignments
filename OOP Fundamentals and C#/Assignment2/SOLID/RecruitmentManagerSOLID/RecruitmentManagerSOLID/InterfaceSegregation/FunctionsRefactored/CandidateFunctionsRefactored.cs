using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagerSOLID.InterfaceSegregation.FunctionsRefactored
{
    class CandidateFunctionsRefactored : ICandidate
    {
        public void SendDesiredSalary()
        {
            Console.WriteLine("Desired salary has been sent");
        }
    }
}
