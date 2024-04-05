using System;
using EmployeeApp.Interfaces;
namespace EmployeeApp
{
    public class Tester : ContractEmployee, ITester
    {
        public string WorkPlace { get; set; }
        public Tester(int employeeId, string firstName, string lastName, 
                        string email, string phone, Gender gender, Address address, 
                        double hourlyPrice, double totalHours)
        : base(employeeId, firstName, lastName, email, phone, gender, address, hourlyPrice, totalHours) { }
        public override string getJobName()
        {
            return "Tester";
        }
        public void doTesting()
        {
            Console.WriteLine("Testing...");
        }
    }
}
