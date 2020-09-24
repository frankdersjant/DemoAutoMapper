using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Address
    {
        public int AddressId { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string City { get; set; }
        public string PostcalCode { get; set; }

        public Address(int addressId, string streetName, string streetNumber, string city, string postcalCode)
        {
            AddressId = addressId;
            StreetName = streetName;
            StreetNumber = streetNumber;
            City = city;
            PostcalCode = postcalCode;
        }
    }
}
