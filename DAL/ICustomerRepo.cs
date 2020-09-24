using BusinessLayer;
using System.Collections.Generic;

namespace DAL
{
    public interface ICustomerRepo
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
    }
}
