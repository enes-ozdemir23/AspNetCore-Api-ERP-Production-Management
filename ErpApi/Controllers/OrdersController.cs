using AutoMapper;
using Erp.BusinessLayer.Abstract;
using Erp.DtoLayer.OrderDto;
using Erp.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ErpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;
        public OrdersController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult OrderList()
        {
            var values = _mapper.Map<List<ResultOrderDto>>(_orderService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddOrder(CreateOrderDto createOrderDto)
        {
            var values=_mapper.Map<Order>(createOrderDto);
            _orderService.TAdd(values);
            return Ok("İşlem Başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteOrder(string code)
        {
            var values = _orderService.TGetByID(code);
            _orderService.TDelete(values);
            return Ok("İşlem Başarılı");
        }

        [HttpPut]
        public IActionResult UpdateOrder(UpdateOrderDto updateOrderDto)
        {
            var values= _mapper.Map<Order>(updateOrderDto);
            _orderService.TUpdate(values);
            return Ok("İşlem Başarılı");
        }

        [HttpGet("{code}")]
        public IActionResult GetOrder(string code)
        {
            var values = _orderService.TGetByID(code);
            return Ok(_mapper.Map<GetOrderDto>(values));

        }
    }
}
