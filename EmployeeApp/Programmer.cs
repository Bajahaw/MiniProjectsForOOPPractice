using System;
using EmployeeApp.Interfaces;
namespace EmployeeApp
{
    public class Programmer : FullTimeEmployee, IProgrammer
    {
        public string WorkPlace { get; set; }
        public Programmer(int employeeId, string firstName, string lastName, 
                            string email, string phone, Gender gender, Address address, double annualSalary)
        : base(employeeId, firstName, lastName, email, phone, gender, address, annualSalary){ }
        public override string getJobName()
        {
            return "Programmer";
        }
        public void doProgramming()
        {
            Console.WriteLine("Coding CSharp...");
        }
    }
}
