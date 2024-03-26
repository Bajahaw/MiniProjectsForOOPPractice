using System;
namespace AnimalHospitalApp
{
    public class AnimalIDInfo
    {
        public Animal Animal { get; set; }
        Animal.AnimalHealth getHealth;
        public AnimalIDInfo(Animal pet)
        {
            Animal = pet;
            getHealth = new Animal.AnimalHealth();
        }
        public override string ToString()
        {
            return string.Format("{0,20} {1,18} {2,30} {3,13} {4,15} {5,13} {6,5} {7,11} {8,9}",
            Animal.Owner.FirstName + " " + Animal.Owner.LastName, 
            Animal.Owner.PhoneNumeber, Animal.Owner.Email,
            Animal.ArrivalDate.ToString("yyyy/MM/dd"),
            Animal.DepartureDate.ToString("yyyy/MM/dd"), Animal.Name, Animal.Age, 
            Animal.Gender, getHealth.isHealthyWeight(Animal.Height,Animal.Weight));
        }
    }
}