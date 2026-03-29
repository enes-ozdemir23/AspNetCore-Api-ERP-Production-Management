using Erp.BusinessLayer.Abstract;
using Erp.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ErpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductionResultsController : ControllerBase
    {
        private readonly IProductionResultService _productionResultService;

        public ProductionResultsController(IProductionResultService productionResultService)
        {
            _productionResultService = productionResultService;
        }

        [HttpGet]
        public IActionResult ProductionResultList()
        {
            var values = _productionResultService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddProductionResult(ProductionResult productionResult)
        {
            _productionResultService.TAdd(productionResult);
            return Ok("İşlem Başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteProductionResult(string code)
        {
            var values = _productionResultService.TGetByID(code);
            _productionResultService.TDelete(values);
            return Ok("İşlem Başarılı");
        }

        [HttpPut]
        public IActionResult UpdateProductionResult(ProductionResult productionResult)
        {
            _productionResultService.TUpdate(productionResult);
            return Ok("İşlem Başarılı");
        }

        [HttpGet("{code}")]
        public IActionResult GetProductionResult(string code)
        {
            var values = _productionResultService.TGetByID(code);
            return Ok(values);
        }

    }
}
