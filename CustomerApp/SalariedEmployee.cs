using System;
namespace CustomerApp
{
    public class SalariedEmployee : Employee
    {
        public double WeeklySalary { set; get; }
        public SalariedEmployee(int id, string firstName, string lastName, DateTime jobStart,
                                 bool isActive, double weeklySalary)
        : base(id,firstName,lastName,jobStart,isActive)
        {
            WeeklySalary = weeklySalary;
        }

        public override double getEarnings()
        {
            return WeeklySalary * 4;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} ({ID} weekly salary: {WeeklySalary})";
        }
    }
}