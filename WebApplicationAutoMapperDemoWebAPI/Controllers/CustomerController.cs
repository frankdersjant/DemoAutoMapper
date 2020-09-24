using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.CustomerServices;
using System.Threading.Tasks;
using WebApplicationAutoMapperDemoWebAPI.DTOs;

namespace WebApplicationAutoMapperDemoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMapper _mapper;
        private ICustomerService _customerService;
        public CustomerController(IMapper mapper, ICustomerService customerService)
        {
            _mapper = mapper;
            _customerService = customerService;
        }

        public async Task<ActionResult<CustomerDTO>> GetOne()
        {
            var model = _mapper.Map<CustomerDTO>(_customerService.GetCustomer(1));
            return model;
        }
    }
}
