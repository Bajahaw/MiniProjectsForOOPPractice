using System;
using System.Security.Cryptography.X509Certificates;

namespace AnimalHospitalApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomGenerator randomGenerator = new RandomGenerator();
            using (StreamWriter writer = new StreamWriter("animal_data.txt"))
            {
                writer.WriteLine(string.Format("{0,20} {1,20} {2,20} {3,20} {4,15} {5,10} {6,10} {7,10} {8,10}",
                                             "Owner name","Owner Phonenumber","Owner Email",
                                             "Arrival","Departure", "Name", "Age", "Gender", "Healthy?"));
                writer.WriteLine();
                for(int i=0; i<10; i++)
                {
                    Animal animal = randomGenerator.generateAnimal();
                    AnimalIDInfo animalIDInfo = new AnimalIDInfo(animal);
                    writer.WriteLine(animalIDInfo.ToString());
                }
                writer.Close();
            }
        }
    }
}