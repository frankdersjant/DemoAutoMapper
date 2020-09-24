using Aliencube.AzureFunctions.Extensions.DependencyInjection.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using FunctionAppAutoMapperDemoAF.Functions;

namespace FunctionAppAutoMapperDemoAF.Mappings
{
    public class MapperModule : Module
    {
        public override void Load(IServiceCollection services)
        {
            services.AddTransient<IGetOneCustomer, GetOneCustomer>();
            services.AddAutoMapper(System.Reflection.Assembly.GetAssembly(this.GetType()));
        }
    }
}
