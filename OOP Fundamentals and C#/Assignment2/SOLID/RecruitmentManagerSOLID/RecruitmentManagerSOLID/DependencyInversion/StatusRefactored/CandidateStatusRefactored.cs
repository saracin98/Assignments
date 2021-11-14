using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagerSOLID.DependencyInversion.StatusRefactored
{
    class CandidateStatusRefactored
    {
        private IUserStatus _userStatus;
        public string Candidate { get; set; }
        public string Status { get; set; }

        public CandidateStatusRefactored(IUserStatus userStatus)
        {
            _userStatus = userStatus;
        }

        public string GetStatus()
        {
            return _userStatus.SetStatus(Candidate, Status);
        }
    }
}
