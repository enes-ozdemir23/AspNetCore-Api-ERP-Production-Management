using AutoMapper;
using Erp.DtoLayer.CustomerDto;
using Erp.EntityLayer.Entities;

namespace ErpApi.Mapping
{
    public class CustomerMapping:Profile
    {
        public CustomerMapping()
        {
            CreateMap<Customer,ResultCustomerDto>().ReverseMap();
            CreateMap<Customer,GetCustomerDto>().ReverseMap();
            CreateMap<Customer,CreateCustomerDto>().ReverseMap();
            CreateMap<Customer,UpdateCustomerDto>().ReverseMap();
        }
    }
}
