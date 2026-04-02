using AutoMapper;
using Erp.DtoLayer.OrderDto;
using Erp.EntityLayer.Entities;

namespace ErpApi.Mapping
{
    public class OrderMapping:Profile
    {
        public OrderMapping()
        {
            CreateMap<Order,ResultOrderDto>().ReverseMap();
            CreateMap<Order,GetOrderDto>().ReverseMap();
            CreateMap<Order,CreateOrderDto>().ReverseMap();
            CreateMap<Order,UpdateOrderDto>().ReverseMap();
        }
    }
}
