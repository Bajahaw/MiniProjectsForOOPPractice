using EmployeeApp.Interfaces;
namespace EmployeeApp
{
    public enum Gender { Female = 0, Male = 1 } // Don't change the indexes!
    public abstract class Employee : IFullName
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set; }
        public Address Address { get; set; }
        protected Employee(int employeeId, string firstName, string lastName, 
                            string email, string phone, Gender gender, Address address)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Gender = gender;
            Address = address;
        }
        public string getBasicInformation()
        {
            return $"Employee ID : {EmployeeId} Name: {getFullName()} Email: {Email} Address: {Address.City} {Address.State} {Address.Street} {Address.Zip}";
        }
        public string getFullName()
        {
            return FirstName + " " + LastName;
        }
        public abstract string getJobName();
        public abstract double getMonthlySalary();
    }
}
