using RecruitmentManagerSOLID.SingleResponsability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagerSOLID.SingleResponsability
{
    public class ProfileDB
    {
        public static List<ProfileDTO> Store = new List<ProfileDTO>();

        public static void AddProfile(ProfileDTO p)
        {
            Store.Add(p);
        }
    }
}
