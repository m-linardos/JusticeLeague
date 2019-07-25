using System;

namespace JusticeLeague.Project {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Hall of Justice Governor Mr. President.");
            Console.WriteLine("Let me introduce you to some of the gang.");

            SuperHero superman = new SuperHero();
           
            superman.firstName                  = "Clark";
            superman.lastName                   = "Kent";
            superman.identityStatus             = "secret";
            superman.planetOfOrigin             = "Krypton";
            superman.birthName                  = "Kal-el";
            superman.groupAlliance              = "Justice League";
            superman.groupAllianceHeadquarters  = "Washington DC";
            superman.jobObligationLevel         = "2";
            superman.skill1                      = "flying";
            superman.skill1Level = "10";
            superman.skill2 = "X-ray vision";
            superman.skill2Level = "9";
            superman.skill3 - 1 = "super strength";
            superman.skill3Level = "10";







            Console.WriteLine("Thank you for touring our facility.");
        }
    }
    class SuperHero {
        public string identityStatus{ get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string planetOfOrigin { get; set; }
        public string birthName { get; set; }
        public string groupAlliance { get; set; }
        public string groupAllianceHeadquarters { get; set; }
        public string publiclyHeldJob { get; set; }
        public string jobObligationLevel { get; set; }
        public string skill { get; set; }
        public string skillLevel { get; set; }
        public string superPowerOrigination { get; set; }
        public string superPowerLevel { get; set; }
        public string familialStatus { get; set; }
        public string familyObligationLevel { get; set; }
        public string goodBehaviorTrait { get; set; }
        public string goodBehaviorTraitLevel { get; set; }
        public string badBehaviorTrait { get; set; }
        public string badBehaviorTraitLevel { get; set; }
        public string weakness { get; set; }
        public string weaknessLevel { get; set; }

        public string specializedTrainingReceived { get; set; }

        public SuperHero(string identityStatus, string firstName, string lastName, 
            string planetOfOrigin, string birthName, string groupAlliance, 
            string groupAllianceHeadquarters, string publiclyHeldJob, string jobObligationLevel,
            string skill, string skillLevel, string superPowerOrigination, string superPowerLevel,
            string familialStatus, string familyObligationLevel, string goodBehaviorTrait, 
            string goodBehaviorTraitLevel, string badBehaviorTrait, string badBehaviorTraitLevel, 
            string weakness, string weaknessLevel, string specializedTrainingReceived) {

            this.identityStatus = identityStatus;
            this.firstName = firstName;
            this.lastName = lastName;
            this.planetOfOrigin = planetOfOrigin;
            this.birthName = birthName;
            this.groupAlliance = groupAlliance;
            this.groupAllianceHeadquarters = groupAllianceHeadquarters;
            this.publiclyHeldJob = publiclyHeldJob;
            this.jobObligationLevel = jobObligationLevel;
            this.skill = skill;
            this.skillLevel = skillLevel;
            this.superPowerOrigination = superPowerOrigination;
            this.superPowerLevel = superPowerLevel;
            this.familialStatus = familialStatus;
            this.familyObligationLevel = familyObligationLevel;
            this.goodBehaviorTrait = goodBehaviorTrait;
            this.goodBehaviorTraitLevel = goodBehaviorTraitLevel;
            this.badBehaviorTrait = badBehaviorTrait;
            this.badBehaviorTraitLevel = badBehaviorTraitLevel;
            this.weakness = weakness;
            this.weaknessLevel = weaknessLevel;
            this.specializedTrainingReceived = specializedTrainingReceived;
        }

        public SuperHero() {
        }

        public void SetIdentityStatus(string identityStatus) {

        if ((identityStatus == "secret")
            || (identityStatus == "revealed")
            || (identityStatus == "in question")) {
            this.IdentityStatus = identitystatus;
        }
        else {
            Console.WriteLine("Status must be secret, revealed, or in question");
        }
    }
}
