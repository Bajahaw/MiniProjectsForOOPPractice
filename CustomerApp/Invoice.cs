using System;

namespace CustomerApp
{
    internal class Invoice
    {
        private double amount;
        public int ID { get; set; }
        public Customer Customer { get; set; }
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public Invoice(int id,Customer customer,double amount ) 
        {
            ID = id;
            Customer = customer;
            Amount = amount;
        }

        public double getAmountAfterDiscount() 
        {
            return amount - Customer.Discount;
        }

        public override string ToString()
        {
            return $"Amount = {amount}";
        }
    }
}