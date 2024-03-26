using System;
using System.Linq;
namespace AnimalHospitalApp
    {
    public enum Gender { Female, Male, Unknown };
    public class Animal
    {
        protected const string NN = "No Name", NS = "No Sound";
        public int? ChipId { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public Gender Gender { get; set; }
        public Owner Owner { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public Animal(DateTime arrival, DateTime departure, double height, double weight, Owner owner = null, int? 
                    chipId = null, int? age = null, Gender gender = Gender.Unknown, string name = NN, 
                    string sound = NS)
        {
            ArrivalDate = arrival;
            DepartureDate = departure;
            Owner = owner;
            ChipId = chipId;
            this.age = age;
            Gender = gender;
            this.name = name;
            this.sound = sound;
            Height = height;
            Weight = weight;

        }
        /*public void makeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }*/
        
        public virtual void makeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value.Any(char.IsDigit) ? NN : value; }
        }
        private int? age;
        public int? Age
        {
            get { return age; }
            set { age = value < 0 ? null : value; }
        }
        private string sound;
        public string Sound
        {
            get { return sound; }
            set { sound = value.Length < 3 ? NS : value; }
        }
        public class AnimalHealth
        {
            public bool isHealthyWeight(double height, double weight)
            {
                double ratio = weight / height;
                return ratio >= 0.18 && ratio <= 0.27;
            }
        }
    }
}
