using System;
using System.Collections.Generic;
using System.Linq;
namespace EmployeeApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region where clause
            // Define the query expression.
            IEnumerable<Employee> empQuery = from emp in DataSource.employees
                                             where emp.ID > 111
                                             select emp;
            // Execute the query.
            Console.WriteLine("Result(s) of query#1:");
            foreach (Employee emp in empQuery)
                Console.WriteLine(emp.ToString());
            IEnumerable<string> fnQuery = from emp in DataSource.employees
                                          where emp.ID > 111
                                          select emp.FirstName;
            Console.WriteLine("Result(s) of query#2:");
            foreach (string fn in fnQuery)
                Console.WriteLine(fn);
            IEnumerable<ContactInfo> ciQuery = from emp in DataSource.employees
                                               where emp.ID > 111
                                               select emp.GetContactInfo(emp.ID);
            Console.WriteLine("Result(s) of query#3:");
            foreach (ContactInfo ci in ciQuery)
                Console.WriteLine(ci.ToString());
            IEnumerable<double> firstSalaryQuery = from emp in DataSource.employees
                                                   where emp.ID > 111
                                                   select emp.Salary[0];
            Console.WriteLine("Result(s) of query#4:");
            foreach (double firstSalary in firstSalaryQuery)
                Console.WriteLine("First Salary = {0}", firstSalary);
            IEnumerable<double> avgSalaryQuery = from emp in DataSource.employees
                                                 where emp.ID > 111
                                                 select emp.Salary.Average();
            Console.WriteLine("Result(s) of query#5:");
            foreach (double avgSalary in avgSalaryQuery)
                Console.WriteLine("Average = {0}", avgSalary);
            var namesQuery = from emp in DataSource.employees
                             where emp.ID > 111
                             select new { emp.FirstName, emp.LastName };
            Console.WriteLine("Result(s) of query#6:");
            foreach (var names in namesQuery)
                Console.WriteLine("{0}, {1}", names.LastName, names.FirstName);
            #endregion
            #region group clause
            var fnGroupQuery = from emp in DataSource.employees
                               group emp by emp.FirstName[0] into g
                               orderby g.Key
                               select g;
            Console.WriteLine("Result(s) of query#7:");
            foreach (IGrouping<char, Employee> fnGroup in fnGroupQuery)
            {
                Console.WriteLine(fnGroup.Key);
                foreach (var fn in fnGroup)
                    Console.WriteLine(" {0}, {1}", fn.FirstName, fn.LastName);
            }
            var empGroupQuery = from employee in DataSource.employees
                                group employee by employee.Salary.Average() >= 120;
            Console.WriteLine("Result(s) of query#8:");
            foreach (var empGroup in empGroupQuery)
            {
                Console.WriteLine(empGroup.Key ? "High salaries" : "Low salaries");
                foreach (var emp in empGroup)
                    Console.WriteLine(" {0}, {1}:{2}", emp.FirstName, emp.LastName,
                   emp.Salary.Average());
            }
            #endregion
            #region join clause
            //inner join
            IEnumerable<ContactInfo> ciDependOnSalaryQuery = from emp in
           DataSource.employees
                                                             where
                                                            emp.Salary.Average() > 120
                                                             join c in
                                                            DataSource.contacts on emp.ID equals c.ID
                                                             select c;
            Console.WriteLine("Result(s) of query#9:");
            foreach (ContactInfo ciDependOnSalary in ciDependOnSalaryQuery)
                Console.WriteLine("ID = {0}, Email = {1}", ciDependOnSalary.ID,
               ciDependOnSalary.Email);

            var empBelongsToEmailQuery = from emp in DataSource.employees
                                         join c in DataSource.contacts on emp.ID
                                        equals c.ID
                                         select new
                                         {
                                             EmployeeID = emp.ID,
                                             Email =
                                        c.Email
                                         };
            Console.WriteLine("Result(s) of query#10:");
            foreach (var empBelongsToEmail in empBelongsToEmailQuery)
                Console.WriteLine("{0,-10}{1}", empBelongsToEmail.EmployeeID,
               empBelongsToEmail.Email);
            Console.WriteLine("InnerJoin: {0} items in 1 group.",
           empBelongsToEmailQuery.Count());

            //group join
            var empByCompanyGroupQuery = from c in DataSource.companies
                                         join emp in DataSource.employees on c.ID
                                        equals emp.CompanyID into empGroup
                                         select empGroup;
            Console.WriteLine("Result(s) of query#11:");
            int totalItems = 0;
            foreach (var empByCompanyGroup in empByCompanyGroupQuery)
            {
                Console.WriteLine("Group:");
                foreach (var empByCompany in empByCompanyGroup)
                {
                    totalItems++;
                    Console.WriteLine(" {0,-10}{1}", empByCompany.FirstName,
                    empByCompany.ID);
                }
            }
            Console.WriteLine("Unshaped GroupJoin: {0} items in {1} unnamed groups",
           totalItems, empByCompanyGroupQuery.Count());

            //group inner join
            var groupInnerJoinQuery = from c in DataSource.companies
                                      orderby c.ID
                                      join emp in DataSource.employees on c.ID equals
                                      emp.CompanyID into empGroup
                                      select new
                                      {
                                          Name = c.Name,
                                          Employees = from subEmpGroup in empGroup
                                                      orderby subEmpGroup.FirstName
                                                      select subEmpGroup
                                      };
            Console.WriteLine("Result(s) of query#12:");
            totalItems = 0;
            foreach (var empGroup in groupInnerJoinQuery)
            {
                Console.WriteLine(empGroup.Name);
                foreach (var emp in empGroup.Employees)
                {
                    totalItems++;
                    Console.WriteLine(" {0,-10} {1}", emp.FirstName, emp.CompanyID);
                }
            }
            Console.WriteLine("GroupInnerJoin: {0} items in {1} named groups",
           totalItems, groupInnerJoinQuery.Count());
            //left outer join
            var empDefaultQuery = from c in DataSource.companies
                                  join emp in DataSource.employees on c.ID equals
                                 emp.CompanyID into empGroup
                                  select empGroup.DefaultIfEmpty(new Employee()
                                  {
                                      ID =
                                 211,
                                      FirstName = "Nothing!",
                                      LastName = "Nothing!",
                                      CompanyID = c.ID,
                                      Salary = new
                                 List<double>() { 2130.3, 4210.5, 3525.6, 4342.2 }
                                  });
            Console.WriteLine("Result(s) of query#13:");
            totalItems = 0;
            foreach (var empGroup in empDefaultQuery)
            {
                Console.WriteLine("Group:", empGroup.Count());
                foreach (var employee in empGroup)
                {
                    totalItems++;
                    Console.WriteLine(" {0,-10} {1}", employee.FirstName,
                    employee.CompanyID);
                }
            }
            Console.WriteLine("LeftOuterJoin: {0} items in {1} groups", totalItems,
           empDefaultQuery.Count());
            #endregion
        }
    }
}