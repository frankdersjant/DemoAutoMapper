using Aliencube.AzureFunctions.Extensions.DependencyInjection.Abstractions;
using AutoMapper;
using BusinessLayer;
using FunctionAppAutoMapperDemoAF.Mappings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace FunctionAppAutoMapperDemoAF.Functions
{
    public class GetOneCustomer : IGetOneCustomer
    {
        private readonly IMapper _mapper;
        public ILogger Log { get; set; }
        public GetOneCustomer(IMapper mapper)
        {
            _mapper = mapper;
        }

        async Task<TOutput> IFunction<ILogger>.InvokeAsync<TInput, TOutput>(TInput input, FunctionOptionsBase options)
        {
            Customer newCustomer = new Customer(3, "Klaas", "Vaak");
            var mapped = this._mapper.Map<CustomerDTO>(newCustomer);

            return (TOutput)(IActionResult)new OkObjectResult(mapped);
        }
    }
}
