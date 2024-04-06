using System;
namespace CustomerApp
{
    public class Account
    {
        private double balance;
        public int ID { set; get; }
        public Customer Customer { set; get; }
        public double Balance
            { 
                set{Balance = value;} 
                get{ return balance;} 
            }
        public Account(int id, Customer customer)
        {
            ID = id;
            Customer = customer;
        }
        public Account(int id, Customer customer, double balance)
        {
            ID = id;
            Customer = customer;
            this.balance = balance;
        }
        public Account deposite(double amount)
        {
            if(amount>0)
                balance += amount;
            return this;
        }
        public Account withdraw(double amount)
        {
            if(balance>=amount)
                balance -= amount;
            return this;
        }
        public override string ToString()
        {
            return $"balance= {balance}";
        }

    }
}