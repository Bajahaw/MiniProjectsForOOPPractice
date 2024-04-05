using System;
namespace EmployeeApp.Helper
{
    public class RandomEmployee
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
        phones = { "50220201781", "86220893102", "61655010413", "58038163444", "91897544945" };
        public static string generateElementOf(string[] strArray)
        {
            return strArray[rnd.Next(strArray.Length)];
        }
        private static int generateZips()
        {
            return rnd.Next(1, 10000 + 1);
        }
        private static Gender generateGender()
        {
            return rnd.Next(2) == 0 ? Gender.Female : Gender.Male;
        }
        private static int generateJob()
        {
            return rnd.Next(3);
        }
        private static Address generateAddress()
        {
            return new Address() { City = generateElementOf(cities), State = 
            generateElementOf(states), Street = generateElementOf(streets), Zip = generateZips() 
            };
        }
        public static Employee generateEmployee()
        {
            Gender gender = generateGender();
            string firstName = generateElementOf(firstNames[(int)gender]),
            lastName = generateElementOf(lastNames);
            Employee employee;
            if (generateJob()==0)
                employee = new Programmer(Id, firstName, lastName, 
                                        Convert.toEmailFormat(firstName, lastName), 
                                        Convert.toHungarianPhoneFormatOf(generateElementOf(phones)), 
                                        gender, generateAddress(), 
                                        rnd.NextDouble() * 100000.0);
            else if (generateJob()==1)
                employee = new SystemEngineer(Id, firstName, lastName, 
                                        Convert.toEmailFormat(firstName, lastName), 
                                        Convert.toHungarianPhoneFormatOf(generateElementOf(phones)), 
                                        gender, generateAddress(), 
                                        rnd.NextDouble() * 100000.0);
            else
                employee = new Tester(Id, firstName, lastName, 
                                    Convert.toEmailFormat(firstName, lastName), 
                                    Convert.toHungarianPhoneFormatOf(generateElementOf(phones)), 
                                    gender, generateAddress(), 
                                    rnd.NextDouble() * 1000.0, rnd.NextDouble() * 13.0);
                                    ++Id;
            return employee;
        }
    }
}
