using BusinessLayer;
using System.Collections.Generic;

namespace ServiceLayer.CustomerServices
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomer(int id);

    }
}
