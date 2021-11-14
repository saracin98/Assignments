using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagerSOLID.DependencyInversion
{
    class CandidateStatus
    {
        public string Candidate { get; set; }
        public string Status { get; set; }

        public CandidateStatus(string candidate, string status)
        {
            Candidate = candidate;
            Status = status;
        }
        public string GetStatus()
        {
            UserStatus userStatus = new UserStatus();
            return userStatus.SetStatus(Candidate,Status);
        }
    }
}
