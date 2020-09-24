using Aliencube.AzureFunctions.Extensions.DependencyInjection;
using Aliencube.AzureFunctions.Extensions.DependencyInjection.Abstractions;
using FunctionAppAutoMapperDemoAF.Functions;
using FunctionAppAutoMapperDemoAF.Mappings;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace FunctionAppAutoMapperDemoAF
{
    public static class GetCustomer
    {
        public static IFunctionFactory Factory = new FunctionFactory<MapperModule>();

        [FunctionName("GetCustomer")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req, ILogger log
             )
        {

            var options = new GetSecretFunctionOptions("Sample");


            var result = await Factory.Create<IGetOneCustomer, ILogger>(log)
                               .InvokeAsync<HttpRequest, IActionResult>(req, options)
                               .ConfigureAwait(false);

            return new OkObjectResult(result);

        }
    }
}
