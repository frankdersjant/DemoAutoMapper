using Aliencube.AzureFunctions.Extensions.DependencyInjection.Abstractions;
using Microsoft.Extensions.Logging;

namespace FunctionAppAutoMapperDemoAF.Functions
{
    public interface IGetOneCustomer : IFunction<ILogger>
    {
    }
}
