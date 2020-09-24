using AutoMapper;
using BusinessLayer;
using WebApplicationAutoMapperDemoWebAPI.DTOs;

namespace WebApplicationAutoMapperDemoWebAPI.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDTO>();
        }
    }
}
