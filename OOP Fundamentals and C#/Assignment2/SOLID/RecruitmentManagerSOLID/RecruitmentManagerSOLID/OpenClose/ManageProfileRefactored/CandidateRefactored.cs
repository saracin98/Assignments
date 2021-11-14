using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagerSOLID.OpenClose.ManageProfileRefactored
{
    class CandidateRefactored : Person
    {
        public string Resume { get; set; }
        public CandidateRefactored(string resume)
        {
            Resume = resume;
        }
        public void ViewProfile()
        {
            Console.WriteLine($"Candidate has the following resume {Resume}");
        }
    }
}
