using AutoMapper;
using BusinessLayer;
using FunctionAppAutoMapperDemoAF.Mappings;

namespace FunctionAppAutoMapperDemoAF.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDTO>();
        }
    }
}
