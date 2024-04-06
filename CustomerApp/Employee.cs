using System;
namespace CustomerApp
{
    public abstract class Employee : Person
    {
        protected DateTime Start { set; get; }
        protected bool IsActive { set; get; }
        protected Employee(int id, string firstName, string
                    lastName, DateTime jobStart, bool isActive)
        : base(id, firstName, lastName)
        {
            Start = jobStart;
            IsActive = isActive;
        }
        public abstract double getEarnings();
        public override string ToString()
        {
            return $"{FirstName} {LastName} ({ID}) since: {Start} active: {IsActive}";
        }
    }
}
