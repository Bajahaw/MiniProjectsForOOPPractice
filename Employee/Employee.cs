using System.Collections.Generic;
using System.Linq;

namespace EmployeeApp
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CompanyID { get; set; }
        public List<double> Salary;

        public ContactInfo GetContactInfo(int id)
        {
            //IEnumerable<ContactInfo> resultiter =
            //    from c in DataSource.contacts
            //    where c.ID == id
            //    select c;
            // or
            //var resultiter =
            //    from c in DataSource.contacts
            //    where c.ID == id
            //    select c;
            //ContactInfo contactInfo = resultiter.FirstOrDefault(); // extension method
            //return contactInfo;

            // shorter form
            //ContactInfo contactInfo =
            //    (from c in DataSource.contacts
            //     where c.ID == id
            //     select c).FirstOrDefault(); // extension method
            //
            //return contactInfo;

            // shortest form
            //return (from c in DataSource.contacts
            //        where c.ID == id
            //        select c).FirstOrDefault(); // extension method
            return DataSource.contacts.FirstOrDefault(c => c.ID == id);
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + ": " + ID;
        }
    }
}