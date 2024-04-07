using System;
namespace CustomerApp
{
    public class Customer : Person
    {
        private int discount;
        public int Discount 
        {
            set{ discount = value; }
            get{ return discount; }
        }
        public string Email { set; get; }
        public string Phone { set; get; }
        public Gender Gender { set; get; }
        public Address Adress { set; get; }
        public Customer(int id, string firstName, string lastName,
                        string email, string phone, Gender gender,
                        Address adress, int discount)
        : base(id, firstName, lastName)
        {
            Email = email;
            Phone = phone;
            Gender = gender;
            Adress = adress;
            Discount = discount;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({ID}) email:{Email} phone: {Phone} gender: {Gender} city: {Adress.City} stete: {Adress.State} street: {Adress.Street} {Adress.Zip} discount: {discount}";
        }
    }
}