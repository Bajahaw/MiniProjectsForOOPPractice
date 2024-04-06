using System;
using EmployeeApp.Interfaces;
namespace EmployeeApp
{
    public class SystemEngineer : CasualEmployee , ISystemEngineer
    {
        public string WorkPlace { get; set; }
        public SystemEngineer(int employeeId, string firstName, string lastName, 
                            string email, string phone, Gender gender, Address address,
                            double hourlyPrice, int systemsDesigned, double bonus, double totalHours)
        : base(employeeId, firstName, lastName, email, phone, gender, address, hourlyPrice, systemsDesigned, bonus, totalHours){ }
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
