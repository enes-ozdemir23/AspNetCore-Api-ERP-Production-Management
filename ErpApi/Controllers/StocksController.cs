using Erp.BusinessLayer.Abstract;
using Erp.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ErpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly IStockService _stockService;

        public StocksController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet]
        public IActionResult StockList()
        {
            var values = _stockService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddStock(Stock stock)
        {
            _stockService.TAdd(stock);
            return Ok("İşlem Başarılı");
        }
        [HttpDelete]
        public IActionResult DeleteStock(string code)
        {
            var values = _stockService.TGetByID(code);
            _stockService.TDelete(values);
            return Ok("İşlem Başarılı");
        }
        [HttpPut]
        public IActionResult UpdateStock(Stock stock)
        {
            _stockService.TUpdate(stock);
            return Ok("Güncelleme Başarılı");
        }

        [HttpGet("{code}")]
        public IActionResult GetStock(string code)
        {
            var values = _stockService.TGetByID(code);
            return Ok(values);
        }
    }
}
