using BusinessLayer;
using DAL;
using System.Collections.Generic;

namespace ServiceLayer.CustomerServices
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepo _customerRepo;

        public CustomerService(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerRepo.GetAllCustomers();
        }

        public Customer GetCustomer(int id)
        {
            return _customerRepo.GetCustomerById(id);
        }
    }
}
