using System;

namespace AirplaneApp
{
    public class RandomPassenger

    {
        private string[] firstNamesFemale =  { "Alexandra", "Alison", "Maria", 
                                        "Sophie", "Wanda" };
        private string[] firstNamesMale = { "Brandon", "David", "Gordon", "Jonathan", "Peter" };
        private string[] lastNames = { "Abraham", "Campbell", "Elison", "Henderson", "Johnston" };
        private Random rnd = new Random();
        private int generateAge()
        {
            return rnd.Next(1,100);
        }
        private string generateElementOf(string[] strArray)
        {
            return strArray[rnd.Next(strArray.Length)];
        }
        private Gender generateGender()
        {
            return rnd.Next(2) == 0 ? Gender.Female : Gender.Male;
        }
        public Passenger generatePassenger()
        {
            Passenger passsenger = new Passenger();
            passsenger.Age = generateAge();
            passsenger.TravelID = generateTravelID();
            passsenger.Gender = generateGender();
            passsenger.Fullname = generateElementOf(passsenger.Gender.Equals(Gender.Female) ?
                                                    firstNamesFemale : firstNamesMale) +" "+ 
                                                    generateElementOf(lastNames);
            return passsenger;                                       
        }
        private string generateTravelID()
        {
            string travelID = "";
            string allowedCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            for(int i=0; i<8; i++)
            {
                travelID+=allowedCharacters[rnd.Next(allowedCharacters.Length)];
            }
            return travelID;
        }

    }
}