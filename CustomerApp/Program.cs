using System;
using CustomerApp;
using CustomerApp.Helper;


namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            List<HourlyEmployee> hourlyEmployees = new List<HourlyEmployee>();
            List<BasePlusComissionEmployee> basePlusComissionEmployees = new List<BasePlusComissionEmployee>();
            List<SalariedEmployee> salariedEmployees  = new List<SalariedEmployee>();

            Person[] people = new Person[20];
            for(int i=0; i<people.Length;i++)
            {
                people[i] = RandomPerson.generatePerson();
                if(people[i] is Customer)
                {
                    customers.Add(people[i] as Customer);
                }
                else if(people[i] is HourlyEmployee)
                {
                    hourlyEmployees.Add(people[i] as HourlyEmployee);
                }
                else if(people[i] is SalariedEmployee)
                {
                    salariedEmployees.Add(people[i] as SalariedEmployee);
                }
                else
                {
                    basePlusComissionEmployees.Add(people[i] as BasePlusComissionEmployee);
                }
            }

            Console.WriteLine("Customers:\n");
            customers.ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Hourly Employees:\n");
            hourlyEmployees.ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Salaried Employees:\n");
            salariedEmployees.ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Base Plus Comission Employees:\n");
            basePlusComissionEmployees.ForEach(Console.WriteLine);
            Console.WriteLine();

        }
    }
}