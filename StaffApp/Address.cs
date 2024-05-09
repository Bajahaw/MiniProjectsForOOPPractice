using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffApp
{
    public class Address
    {

        public AddressType Type { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Country { get; set; }

        public Address(AddressType type, string street, string city, string state, int zip, string country)
        {
            Type = type;
            Street = street;
            City = city;
            State = state;
            Zip = zip;
            Country = country;
        }
    }
}
