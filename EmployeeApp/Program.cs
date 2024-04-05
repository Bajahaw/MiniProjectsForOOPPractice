using System;
using System.Collections.Generic;
using System.IO;
using EmployeeApp.Helper;
using EmployeeApp.Interfaces;
namespace EmployeeApp
{
    class Program
    {
        static void listToConsole<T>(List<T> employees) where T : IFullName
        {
            foreach (T employee in employees)
            Console.WriteLine(employee.getFullName());
        }
        static void Main()
        {
            RandomEmployee.Id = 1;
            List<Programmer> programmers = new List<Programmer>();
            List<Tester> testers = new List<Tester>();
            List<SystemEngineer> systemEngineers = new List<SystemEngineer>();
            using (StreamWriter file = new StreamWriter("employees.txt", false))
            {
                const string formatstr = "{0,3} {1,20} {2,6} {3,30} {4,15} {5,15} {6,20} {7,20} {8,30} {9,10} ";
                file.WriteLine(formatstr + "{10,10}", "EID", "Name", "Gender", "Email", "Phone", "Job","City", "State", "Street", "Zip", "Salary");
                for (int i = 0; i < 20; ++i)
                {
                    Employee employee = RandomEmployee.generateEmployee();
                    if (employee is Programmer)
                        programmers.Add(employee as Programmer);
                    else if(employee is Tester)
                    {
                        Tester tester = employee as Tester;
                        testers.Add(tester);
                        //testers.Add((Tester)employee);
                    }
                    else
                    {
                        systemEngineers.Add((SystemEngineer)employee);
                    }
                    file.WriteLine(formatstr + "{10,10:#.##}", employee.EmployeeId, 
                    employee.getFullName(), 
                    employee.Gender, employee.Email, employee.Phone, 
                    employee.getJobName(), 
                    employee.Address.City, employee.Address.State, 
                    employee.Address.Street, 
                    employee.Address.Zip, employee.getMonthlySalary());
                }
            }
            Console.WriteLine("PROGRAMMERS");
            listToConsole(programmers);
            Console.WriteLine();
            Console.WriteLine("TESTERS");
            listToConsole(testers);
            Console.WriteLine();
            Console.WriteLine("SYSTEM ENGINEERS");
            listToConsole(systemEngineers);
        }
    }
}
