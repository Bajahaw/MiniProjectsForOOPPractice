using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StaffApp
{
    public class Member
    {

        public int Id { get; set; }
        public Department Dept { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public int Salary { get; set; }
        public double? Bonus { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public Address Address { get; set; }
        public Member(int id, Department dept, string name, int grade, int salary, double? bonus, string homePhone, string workPhone, Address address)
        {
            Id = id;
            Dept = dept;
            Name = name;
            Grade = grade;
            Salary = salary;
            Bonus = bonus;
            HomePhone = homePhone;
            WorkPhone = workPhone;
            Address = address;
        }

       
    }
}
