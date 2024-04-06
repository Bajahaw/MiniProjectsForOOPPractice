namespace EmployeeApp
{
    public abstract class CasualEmployee : Employee
    {
        public double Bonus { get; set; }
        public double DoneTasks { get; set; }
        public double HourlyPrice { get; set; }
        public double TotalHours { get; set; }
        protected CasualEmployee(int employeeID, string firstName, string lastName, string email, 
                                    string phone, Gender gender, Address address, double hourlyPrice,
                                    int doneTasks, double bonus, double totalHours)
        : base(employeeID, firstName, lastName, email, phone, gender, address)
        {
            DoneTasks = doneTasks;
            Bonus = bonus;
            HourlyPrice = hourlyPrice;
            TotalHours = totalHours;
        }
        public override double getMonthlySalary()
        {
            return TotalHours * HourlyPrice + DoneTasks * Bonus;
        }
    }
}
