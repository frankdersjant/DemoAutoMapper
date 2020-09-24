using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.CustomerServices;
using System.Collections.Generic;
using WebAppAutoMapperDemo.ViewModels;

namespace WebAppAutoMapperDemo.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IMapper _mapper;
        private ICustomerService _customerService;
        public CustomerController(IMapper mapper, ICustomerService customerService)
        {
            _mapper = mapper;
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            var model = _mapper.Map<IEnumerable<CustomerVM>>(_customerService.GetAllCustomers());
            return View(model);
        }

        public IActionResult GetOne()
        {
            var model = _mapper.Map<CustomerAddressVM>(_customerService.GetCustomer(1));
            return View(model);
        }
    }
}
