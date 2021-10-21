using RecruitmentManagerSOLID.DependencyInversion;
using RecruitmentManagerSOLID.DependencyInversion.StatusRefactored;
using RecruitmentManagerSOLID.InterfaceSegregation;
using RecruitmentManagerSOLID.InterfaceSegregation.FunctionsRefactored;
using RecruitmentManagerSOLID.LiskovSubstitution;
using RecruitmentManagerSOLID.OpenClose;
using RecruitmentManagerSOLID.OpenClose.ManageProfile;
using RecruitmentManagerSOLID.OpenClose.ManageProfileRefactored;
using RecruitmentManagerSOLID.SingleResponsability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagerSOLID
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Single Responsability principle
                    //Not using principle
            ProfileService profileService = new ProfileService();        
            profileService.CreateProfile("bob", "bob@bobdemia.com");

                    //Using principle 
            ProfileServiceRefactored profileServiceRefactored = new ProfileServiceRefactored();
            profileServiceRefactored.CreateProfile("bob", "bob@bobdemia.com");

            //Open/Closed principle
                    //Not using principle
            ManageProfile manageProfile = new ManageProfile() ;
            User user1 = new User("something123","admin");
            Candidate candidate1 = new Candidate("resume.pdf");
            manageProfile.ViewProile(new List<Object>() { user1, candidate1 });

                    //Using principle 
            ManageProfileRefactored manageProfileRefactored = new ManageProfileRefactored();
            UserRefactored user2 = new UserRefactored("user312", "user");
            CandidateRefactored candidate2 = new CandidateRefactored("candidateName_resume.pdf");
            manageProfileRefactored.ViewProfile(new List<Person>() { user2, candidate2 });

            //LiskovSubstitution principle
                    //Not using principle
            Company company1 = new Job();
            company1.GetDescription();

                    //Using principle 
            Company company2 = new JobRefactored();
            company2.GetDescription();

            //InterfaceSegregation principle
                    //Not using principle
            CandidateFunctions candidate3 = new CandidateFunctions();
            candidate3.SendDesiredSalary();
            //candidate3.SendJobDescription();

                    //Using principle 
            CandidateFunctionsRefactored candidate4 = new CandidateFunctionsRefactored();
            candidate4.SendDesiredSalary();

            //DependencyInversion principle
                    //Not using principle
            CandidateStatus candidate5 = new CandidateStatus("Jhon","Hired");
            Console.WriteLine(candidate5.GetStatus());

            //Using principle
            CandidateStatusRefactored candidate6 = new CandidateStatusRefactored(new UserStatusRefactored());
            candidate6.Candidate = "Bob";
            candidate6.Status = "Rejected";
            Console.WriteLine(candidate6.GetStatus());

            Console.ReadLine();

        }
    }
}
