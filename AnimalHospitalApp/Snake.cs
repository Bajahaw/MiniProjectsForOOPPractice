using System;
namespace AnimalHospitalApp
{
    class Snake : Animal
    {
        private int? feedPeriod;
        public string SnakeSound { get; set; }
        public Snake(DateTime arrival, DateTime departure, double height, double weight, Owner owner, int? chipId = 
                    null, int? age = null, Gender gender = Gender.Unknown,
                    string name = NN, string sound = NS)
        : base(arrival, departure, height,  weight, owner, chipId, age, gender, name, sound) { }
        public Snake(DateTime arrival, DateTime departure, double height, double weight, int? feedPeriod, Owner 
                    owner = null, string name = NN, int? chipId = null,
                    int? age = null, Gender gender = Gender.Unknown, string snakeSound = NS)
        : base(arrival, departure, height,  weight, owner, chipId, age, gender, name, snakeSound)
        {
            SnakeSound = snakeSound;
            this.feedPeriod = feedPeriod;
        }
        public int? getFeedPeriod()
        {
            return feedPeriod != null ? feedPeriod : null;
        }
        public void setFeedPeriod(int period)
        {
            feedPeriod = period;
        }
        public override void makeSound()
        {
            Console.WriteLine($"{Name} says {SnakeSound}");
        }
        /*public new void makeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {DogSound}");
        }*/
    }
}
