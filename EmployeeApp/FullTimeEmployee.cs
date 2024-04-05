namespace EmployeeApp
{
    public abstract class FullTimeEmployee : Employee
    {
        public double AnnualSalary { get; set; }
        protected FullTimeEmployee(int employeeId, string firstName, string lastName, string email, 
                                    string phone, Gender gender, Address address, double annualSalary)
        : base(employeeId, firstName, lastName, email, phone, gender, address)
        {
            AnnualSalary = annualSalary;
        }
        public override double getMonthlySalary()
        {
            return AnnualSalary / 12.0;
        }
    }
}