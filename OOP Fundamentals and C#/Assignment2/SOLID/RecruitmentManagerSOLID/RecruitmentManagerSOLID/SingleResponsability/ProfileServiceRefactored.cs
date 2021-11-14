using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagerSOLID.SingleResponsability
{
    class ProfileServiceRefactored
    {
        private CompanyRepository _companyRepository;
        private ProfileRepository _profileRepository;

        public ProfileServiceRefactored()
        {
            _companyRepository = new CompanyRepository();
            _profileRepository = new ProfileRepository();
        }

        public void CreateProfile(string name, string email)
        {
            ProfileDTO profile = new ProfileDTO(name, email);
            _profileRepository.Create(profile);
            _companyRepository.NotifyCompany(profile);
        }
    }
}
