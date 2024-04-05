using System;
using EmployeeApp.Interfaces;
namespace EmployeeApp
{
    public class SystemEngineer : FullTimeEmployee, ISystemEngineer
    {
        public string WorkPlace { get; set; }
        public SystemEngineer(int employeeId, string firstName, string lastName, 
                            string email, string phone, Gender gender, Address address, double annualSalary)
        : base(employeeId, firstName, lastName, email, phone, gender, address, annualSalary){ }
        public override string getJobName()
        {
            return "System Engineer";
        }
        public void designSystem()
        {
            Console.WriteLine("Designing new system ... ");
        }
    }
}
