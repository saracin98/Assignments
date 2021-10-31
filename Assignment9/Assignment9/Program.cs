using Assignment9.Builder;
using Assignment9.FactoryMethod;
using Assignment9.Singleton;
using System;

namespace Assignment9
{
    class Program
    {
        static void Main(string[] args)
        {
            //FactoryMethod
            UserFactory userFactory = new UserFactory();
            CandidateFactory candidateFactory = new CandidateFactory();

            IPerson user = userFactory.CreatePerson("admin","admin@gmail.com");
            IPerson candidate = candidateFactory.CreatePerson("Jhon Smith", "jhom.smith@gmail.com");

            user.SendResume();
            candidate.SendResume();

            //Singleton
            var company1 = Company.Instance;
            var company2 = Company.Instance;

            Console.WriteLine(company2 == company1);

            //Builder
            Profile profile = new ProfileBuilder("Jhon","email","0412512").Build();
            Console.WriteLine(profile.ToString());
        }
    }
}
