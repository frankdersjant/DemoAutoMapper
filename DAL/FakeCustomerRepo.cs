using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class FakeCustomerRepo : ICustomerRepo
    {
        private List<Customer> lstCustomers;

        public FakeCustomerRepo()
        {
            lstCustomers = new List<Customer>();

            Customer customer1 = new Customer(1, "Sjaak", "Pieterse");
            Customer customer2 = new Customer(2, "Bert", "Koolmees");

            Address address1 = new Address(1, "Kerkstraat", "12B", "Hoorn", "1699AB");
            Address address2 = new Address(2, "Bergstraat", "18", "Amsterdam", "1044BD");
            customer1.HomeAddress = address1;
            customer2.HomeAddress = address2;

            lstCustomers.Add(customer1);
            lstCustomers.Add(customer2);
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return lstCustomers.AsEnumerable();
        }

        public Customer GetCustomerById(int id)
        {
            return lstCustomers.Find(x => x.CustomerId == id);
        }
    }
}
