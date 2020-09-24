using AutoMapper;
using BusinessLayer;
using WebAppAutoMapperDemo.ViewModels;

namespace WebAppAutoMapperDemo.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerVM>();
            CreateMap<Customer, CustomerAddressVM>().ForMember(d => d.PostalCode, opts => opts.MapFrom(source => source.HomeAddress.PostcalCode));
        }
    }
}
