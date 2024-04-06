using System;
namespace CustomerApp
{
    public class HourlyEmployee:Employee
    {
        private double wage;
        private int hours;
        public double Wage 
        {
            set{ Wage = value; }
            get{ return wage; }
        }
        public int Hours 
        {
            set{ Hours = value; }
            get{ return hours; }
        }
        public HourlyEmployee(int id, string firstName, string lastName, DateTime jobStart,
                                 bool isActive, double wage, int hours)
        : base(id, firstName, lastName, jobStart, isActive)
        {
            this.wage = wage;
            this.hours = hours;
        }
        public override double getEarnings()
        {
            if (hours <= 40)
                return Wage * Hours;
            else if (hours > 40)
                return 40 * Wage + (Hours - 40) * Wage * 1.5; 
            else
                return 0;
                
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} ({ID}) wage: {wage} hours worked: {hours}";
        }
    }
}