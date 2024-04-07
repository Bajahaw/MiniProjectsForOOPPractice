using System;
namespace CustomerApp
{
    public enum Gender { F, M }
    public abstract class Person
    {
        protected int ID { set; get; }
        protected string FirstName { set; get; }
        protected string LastName { set; get; }
        protected Person(int id, string firstName, string lastName)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
        }
        public Person()
        {
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} ({ID})";
        }
    }
}