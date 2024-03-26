using System;
namespace AnimalHospitalApp
{
    public class RandomGenerator
    {
        Random random = new Random();
        string[] firstNames =  { "Alexandra", "Alison", "Maria", 
                                        "Sophie", "Wanda","Brandon", "David",
                                         "Gordon", "Jonathan", "Peter" };
        string[] lastNames = { "Abraham", "Campbell", "Elison", "Henderson", "Johnston" };
        char[] chars = {'G','N','K','L','S','T'};
        char[] chars2 = {'I','A','U'};

        public Owner generateRandomOwner()
        {
            Owner owner = new Owner();
            owner.FirstName = firstNames[random.Next(firstNames.Length)];
            owner.LastName = lastNames[random.Next(lastNames.Length)];
            owner.Email = owner.FirstName.ToLower()+"."+owner.LastName.ToLower()+"@owner.com";
            owner.PhoneNumeber = "+3 "+random.Next(600000000,700000000);
            return owner;
        }
        public Animal generateAnimal()
        {
            Animal animal;
            int chooser = random.Next(4);
            if(chooser==1)
            {
                animal = generateCat();
            }
            else if(chooser==2)
            {
                animal = generateSnake();
            }
            else if(chooser==3)
            {
                animal = generateDuck();
            }
            else 
            {
                animal = generateDog();
            }
            return animal;
        }

        private Animal generateDog()
        {
            int randomYear = random.Next(2020,2024);
            int randomMonth = random.Next(1,12);
            int randomDay = random.Next(1,30);
            string name = ""+chars[random.Next(chars.Length)]+chars2[random.Next(chars2.Length)]+chars[random.Next(chars.Length)]+chars2[random.Next(chars2.Length)]+" dog!";
            Dog dog = new Dog(new DateTime(randomYear,randomMonth,randomDay),new DateTime(randomYear,randomMonth+random.Next(12-randomMonth),random.Next(1,30)),
                                random.NextDouble()*100,random.NextDouble()*50,generateRandomOwner(),random.Next(10000,20000),random.Next(5),(Gender)random.Next(3),name,"bark");
            return dog;
            
        }

        private Animal generateCat()
        {
            int randomYear = random.Next(2020,2024);
            int randomMonth = random.Next(1,12);
            int randomDay = random.Next(1,30);
            string name = ""+chars[random.Next(chars.Length)]+chars2[random.Next(chars2.Length)]+chars[random.Next(chars.Length)]+chars2[random.Next(chars2.Length)]+" cat!";
            Cat cat = new Cat(new DateTime(randomYear,randomMonth,randomDay),new DateTime(randomYear,randomMonth+random.Next(12-randomMonth),random.Next(1,30)),
                                random.NextDouble()*100,random.NextDouble()*50,generateRandomOwner(),random.Next(10000,20000),random.Next(5),(Gender)random.Next(3),name,"meow");
            return cat;
        }
        private Animal generateSnake()
        {
            int randomYear = random.Next(2020,2024);
            int randomMonth = random.Next(1,12);
            int randomDay = random.Next(1,30);
            string name = ""+chars[random.Next(chars.Length)]+chars2[random.Next(chars2.Length)]+chars[random.Next(chars.Length)]+chars2[random.Next(chars2.Length)]+" snake!";
            Snake snake = new Snake(new DateTime(randomYear,randomMonth,randomDay),new DateTime(randomYear,randomMonth+random.Next(12-randomMonth),random.Next(1,30)),
                                random.NextDouble()*100,random.NextDouble()*50,generateRandomOwner(),random.Next(10000,20000),random.Next(5),(Gender)random.Next(3),name);
            return snake;
        }
        private Animal generateDuck()
        {
            int randomYear = random.Next(2020,2024);
            int randomMonth = random.Next(1,12);
            int randomDay = random.Next(1,30);
            string name = ""+chars[random.Next(chars.Length)]+chars2[random.Next(chars2.Length)]+chars[random.Next(chars.Length)]+chars2[random.Next(chars2.Length)]+" duck!";
            Duck duck = new Duck(new DateTime(randomYear,randomMonth,randomDay),new DateTime(randomYear,randomMonth+random.Next(12-randomMonth),random.Next(1,30)),
                                random.NextDouble()*100,random.NextDouble()*50,generateRandomOwner(),random.Next(10000,20000),random.Next(5),(Gender)random.Next(3),name);
            return duck;
        }
    }
}