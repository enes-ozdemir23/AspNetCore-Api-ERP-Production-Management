using Erp.BusinessLayer.Abstract;
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

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult OrderList()
        {
            var values = _orderService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddOrder(Order order)
        {
            _orderService.TAdd(order);
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
        public IActionResult UpdateOrder(Order order)
        {
            _orderService.TUpdate(order);
            return Ok("İşlem Başarılı");
        }

        [HttpGet("{code}")]
        public IActionResult GetOrder(string code)
        {
            var values = _orderService.TGetByID(code);
            return Ok(values);

        }
    }
}
