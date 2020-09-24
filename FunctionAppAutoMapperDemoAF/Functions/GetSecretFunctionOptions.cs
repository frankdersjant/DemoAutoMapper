using Aliencube.AzureFunctions.Extensions.DependencyInjection.Abstractions;

namespace FunctionAppAutoMapperDemoAF.Functions
{
    public class GetSecretFunctionOptions : FunctionOptionsBase
    {
        public string Name { get; set; }
        public GetSecretFunctionOptions(string name)
        {
            Name = name;
        }
    }
}
