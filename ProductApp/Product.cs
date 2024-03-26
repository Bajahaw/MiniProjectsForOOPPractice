using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    public enum Availability { Available, NotAvailable };
    internal class Product
    {
        string code;
        DateTime dateOfOutcome;
        bool isAvailable;
        string name;
        double price;

        public String getAvailability()
        {
            return isAvailable ? Availability.Available.ToString() : Availability.NotAvailable.ToString();
        }
        public string getCode()
        {
            return code;
        }
        public DateTime getDateOfOutcome()
        {
            return dateOfOutcome;
        }
        public string getName()
        {
            return name;
        }
        public double getPrice()
        {
            return price;
        }
        public void setAvailability(bool isAvailable)
        {
            this.isAvailable = isAvailable;
        }
        public void setDateOfOutcome(DateTime x)
        {
            this.dateOfOutcome = x;
        }
        public void setCode(string code)
        {
            this.code = code;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }
        
        public override string ToString()
        {
            return "Product: " + name + "\nCode: " + code + "\nPrice: " + price + "\nAvailable: " + getAvailability();
        }
        
    }
}
