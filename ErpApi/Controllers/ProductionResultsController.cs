using AutoMapper;
using Erp.BusinessLayer.Abstract;
using Erp.DtoLayer.ProductionResultDto;
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
        private readonly IMapper _mapper;
        public ProductionResultsController(IProductionResultService productionResultService, IMapper mapper)
        {
            _productionResultService = productionResultService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductionResultList()
        {
            var values = _mapper.Map<List<ResultProductionResultDto>>(_productionResultService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddProductionResult(CreateProductionResultDto createProductionResultDto)
        {
            var values= _mapper.Map<ProductionResult>(createProductionResultDto);
            _productionResultService.TAdd(values);
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
        public IActionResult UpdateProductionResult(UpdateProductionResultDto updateProductionResultDto)
        {
            var values=_mapper.Map<ProductionResult>(updateProductionResultDto);
            _productionResultService.TUpdate(values);
            return Ok("İşlem Başarılı");
        }

        [HttpGet("{code}")]
        public IActionResult GetProductionResult(string code)
        {
            var values = _productionResultService.TGetByID(code);
            return Ok(_mapper.Map<GetProductionResultDto>(values));
        }

    }
}
