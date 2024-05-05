using System.Collections.Generic;
namespace EmployeeApp
{
    public static class DataSource
    {
        public static List<Employee> employees = new List<Employee>()
        {
            new Employee {ID=111, CompanyID=111, FirstName="Joseph", LastName="Evans",Salary=new List<double>() {120.2, 356.2, 160.1, 100.99}},
            new Employee {ID=112, CompanyID=111, FirstName="Savannah",LastName="Tower", Salary=new List<double>() {80.9, 90.4, 94.3, 20.3}},
            new Employee {ID=113, CompanyID=112, FirstName="David",LastName="Langley", Salary=new List<double>() {200.1, 320,2, 255,5, 300,9}},
            new Employee {ID=114, CompanyID=111, FirstName="James", LastName="Pardee",Salary=new List<double>() {30.3, 40.5, 35.6, 43.2}}
        };
        public static List<ContactInfo> contacts = new List<ContactInfo>()
        {
            new ContactInfo {ID=111, Email="JosephMEvans@jourrapide.com", Phone="660-928-6465"},
            new ContactInfo {ID=112, Email="SavannahCTower@rhyta.com", Phone="312-972-3816"},
            new ContactInfo {ID=113, Email="DavidJLangley@dayrep.com", Phone="423-303-6671"},
            new ContactInfo {ID=114, Email="JamesAPardee@teleworm.us", Phone="978-296-9082"}
        };
        public static List<Company> companies = new List<Company>()
        {
            new Company {ID=111, Name="Friendly Advice"},
            new Company {ID=112, Name="Success Is Yours"},
            new Company {ID=113, Name="Destiny Realty Solutions"}
        };
    }
}
