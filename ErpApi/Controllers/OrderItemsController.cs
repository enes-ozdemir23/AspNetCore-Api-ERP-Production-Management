using Erp.BusinessLayer.Abstract;
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

        public OrderItemsController(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }

        [HttpGet]
        public IActionResult OrderItemList()
        {
            var values=_orderItemService.TGetListAll().
                     OrderByDescending(x => x.OrderItemId)
                    .Take(50)
                    .ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddOrderItem(OrderItem orderItem) 
        {
            _orderItemService.TAdd(orderItem);
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
        public IActionResult UpdateOrderItem(OrderItem orderItem)
        {
            _orderItemService.TUpdate(orderItem);
            return Ok("İşlem Başarılı");
        }

        [HttpGet("{id}")]
        public IActionResult GetOrderItem(int id)
        {
            var values = _orderItemService.TGetByID(id);
            return Ok(values);
        }
    }
}
