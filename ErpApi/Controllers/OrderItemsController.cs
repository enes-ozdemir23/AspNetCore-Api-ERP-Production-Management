using AutoMapper;
using Erp.BusinessLayer.Abstract;
using Erp.DtoLayer.OrderItemDto;
using Erp.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ErpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemsController : ControllerBase
    {
        private readonly IOrderItemService _orderItemService;
        private readonly IMapper _mapper;
        public OrderItemsController(IOrderItemService orderItemService, IMapper mapper)
        {
            _orderItemService = orderItemService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult OrderItemList()
        {
            var values=_orderItemService.TGetListAll().
                     OrderByDescending(x => x.OrderItemId)
                    .Take(50)
                    .ToList();
            return Ok(_mapper.Map<List<ResultOrderItemDto>>(values));
        }

        [HttpPost]
        public IActionResult AddOrderItem(CreateOrderItemDto createOrderItemDto) 
        {
            var values=_mapper.Map<OrderItem>(createOrderItemDto);
            _orderItemService.TAdd(values);
            return Ok("İşlem Başarılı");

        }

        [HttpDelete]
        public IActionResult DeleteOrderItem(int id)
        {
            var values = _orderItemService.TGetByID(id);
            _orderItemService.TDelete(values);
            return Ok("İşlem Başarılı");
        }

        [HttpPut]
        public IActionResult UpdateOrderItem(UpdateOrderItemDto updateOrderItemDto)
        {
            var values=_mapper.Map<OrderItem>(updateOrderItemDto);
            _orderItemService.TUpdate(values);
            return Ok("İşlem Başarılı");
        }

        [HttpGet("{id}")]
        public IActionResult GetOrderItem(int id)
        {
            var values = _orderItemService.TGetByID(id);
            return Ok(_mapper.Map<GetOrderItemDto>(values));
        }
    }
}
