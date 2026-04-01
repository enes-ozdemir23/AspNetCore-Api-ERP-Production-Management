using AutoMapper;
using Erp.DtoLayer.DistrictDto;
using Erp.DtoLayer.OrderItemDto;
using Erp.EntityLayer.Entities;

namespace ErpApi.Mapping
{
    public class OrderItemMapping:Profile
    {
        public OrderItemMapping()
        {
            CreateMap<OrderItem, ResultOrderItemDto>().ReverseMap();
            CreateMap<OrderItem, UpdateOrderItemDto>().ReverseMap();
            CreateMap<OrderItem, GetOrderItemDto>().ReverseMap();
            CreateMap<OrderItem, CreateOrderItemDto>().ReverseMap();

        }
    }
}
