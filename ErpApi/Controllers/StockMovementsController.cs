using Erp.BusinessLayer.Abstract;
using Erp.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ErpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockMovementsController : ControllerBase
    {
        private readonly IStockMovementService _stockMovementService;

        public StockMovementsController(IStockMovementService stockMovementService)
        {
            _stockMovementService = stockMovementService;
        }

        [HttpGet]
        public IActionResult StockMovementList()
        {
            var values = _stockMovementService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddStockMovement(StockMovement stockMovement)
        {
            _stockMovementService.TAdd(stockMovement);
            return Ok("İşlem Başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteStockMovement(int id)
        {
            var values = _stockMovementService.TGetByID(id);
            _stockMovementService.TDelete(values);
            return Ok("İşlem Başarılı");
        }

        [HttpPut]
        public IActionResult UpdateStockMovement(StockMovement stockMovement)
        {
            _stockMovementService.TUpdate(stockMovement);
            return Ok("İşlem Başarılı");

        }

        [HttpGet("{id}")]
        public IActionResult GetStockMovement(int id)
        {
            var values = _stockMovementService.TGetByID(id);
            return Ok(values);
        }
    }
}
