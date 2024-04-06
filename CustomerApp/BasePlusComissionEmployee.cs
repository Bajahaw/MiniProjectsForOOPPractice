using System;
namespace CustomerApp
{
    public class BasePlusComissionEmployee : Employee
    {
        private double baseSalary;
        private double grossSales; 
        private double comissionRate;
        public double BaseSalary
        {
            set{ BaseSalary = value; }
            get{ return baseSalary; }
        }
        public double GrossSales
        {
            set{ GrossSales = value; }
            get{ return grossSales; }
        } 
        public double ComissionRate
        {
            set{ ComissionRate = value; }
            get{ return comissionRate; }
        }

        public BasePlusComissionEmployee(int id, string firstName, string lastName,  DateTime startJob,
                                     bool isActive, double baseSalary, double grossSales, int comissionRate)
        : base(id, firstName, lastName, startJob, isActive)
        {
            this.baseSalary = baseSalary;
            this.comissionRate = comissionRate;
            this.grossSales = grossSales;
        }

        public override double getEarnings()
        {
            return baseSalary + (comissionRate*grossSales);
        }
        public override string ToString()
        {
            return $"{FirstName} {FirstName} ({ID}) base salary: {baseSalary} gross sales: {grossSales} comission rate: {comissionRate}";
        }
    }
}