using System;
namespace AnimalHospitalApp
{
    class Cat : Animal
    {
        private int? feedPeriod;
        private int? legsMissing;
        private readonly int numberOfLegs = 4;
        public string CatSound { get; set; }
        public Cat(DateTime arrival, DateTime departure, double height, double weight, Owner owner = null, int? 
                    chipId = null, int? age = null, Gender gender = Gender.Unknown,
                    string name = NN, string sound = NS)
        : base(arrival, departure, height,  weight, owner, chipId, age, gender, name, sound) { }
        public Cat(DateTime arrival, DateTime departure, double height, double weight, int? feedPeriod, int? 
                    legsMissing, Owner owner = null, string name = NN, int? chipId = null,
                    int? age = null, Gender gender = Gender.Unknown, string catSound = NS)
        : base(arrival, departure, height,  weight, owner, chipId, age, gender, name, catSound)
        {
            CatSound = catSound;
            this.feedPeriod = feedPeriod;
            this.legsMissing = legsMissing;
        }
        public int? getFeedPeriod()
        {
            return feedPeriod != null ? feedPeriod : null;
        }
        public void setFeedPeriod(int period)
        {
            feedPeriod = period;
        }
        public int? getNumberOfLegs()
        {
            return legsMissing != null ? numberOfLegs - legsMissing : numberOfLegs;
        }
        public void setNumberOfLegs(int legs)
        {
            legsMissing = legs;
        }
        public override void makeSound()
        {
            Console.WriteLine($"{Name} says {CatSound}");
        }
        /*public new void makeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {DogSound}");
        }*/
    }
}
