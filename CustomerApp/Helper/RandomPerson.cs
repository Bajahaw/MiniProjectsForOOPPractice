using System;
namespace CustomerApp.Helper
{
    public class RandomPerson
    {
        public static int Id;
        private static Random rnd = new Random();
        private static string[][] firstNames = { new string[] { "Alexandra", "Alison", "Maria", "Sophie", "Wanda" },
        new string[] { "Brandon", "David", "Gordon", "Jonathan", "Peter" } };
        private static string[] lastNames = { "Abraham", "Campbell", "Ellison", "Henderson", "Johnston" },
        streets = { "2708 Adonais Way", "4154 Cherry Tree Drive", "3466 Wilmar Farm Road",
        "1949 Jadewood Drive", "501 Blane Street" },
        cities = { "Atlanta", "Jacksonville", "Lanham", "Wheatfield", "Fairview Heights" },
        states = { "Georgia(GA)", "Florida(FL)", "Maryland(MD)", "Indiana(IN)", 
        "Missouri(MO)" },
        domainName = { "hotmail", "gmail", "yahoo", "freemail", "company" },
        phones = { "50220201781", "86220893102", "61655010413", "58038163444", "91897544945" },
        extension = { "com", "net", "eu", "hu", "uk" };
        public static string generateElementOf(string[] strArray)
        {
            return strArray[rnd.Next(strArray.Length)];
        }
        private static DateTime generateStart()
        {
            return DateTime.Now.AddDays(-rnd.Next(365));
        }
        private static bool generateIsActive()
        {
            return rnd.Next(2)==0? true : false;
        }
        private static Gender generateGender()
        {
            return rnd.Next(2) == 0 ? Gender.F : Gender.M;
        }
        private static Address generateAddress()
        {
            return new Address() { City = generateElementOf(cities), State = 
            generateElementOf(states), Street = generateElementOf(streets), Zip = generateZips() 
            };
        }
        private static int generateZips()
        {
            return rnd.Next(1, 10000 + 1);
        }
        public static Person generatePerson()
        {
            
        }
        public static string generateEmail(string firstName, string lastName)
        {
            return $"{firstName.ToLower()}.{lastName.ToLower()}@{RandomPerson.generateElementOf(domainName)}.{RandomPerson.generateElementOf(extension)}";
        }
        private static string generatePhone()
        {
            return generateElementOf(phones);
        }
    }
}
