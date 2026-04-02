using AutoMapper;
using Erp.BusinessLayer.Abstract;
using Erp.DtoLayer.StockDto;
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
        private readonly IMapper _mapper;
        public StocksController(IStockService stockService, IMapper mapper)
        {
            _stockService = stockService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult StockList()
        {
            var values = _mapper.Map<List<ResultStockDto>>(_stockService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddStock(CreateStockDto createStockDto)
        {
            var values=_mapper.Map<Stock>(createStockDto);
            _stockService.TAdd(values);
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
        public IActionResult UpdateStock(UpdateStockDto updateStockDto)
        {
            var values=_mapper.Map<Stock>(updateStockDto);
            _stockService.TUpdate(values);
            return Ok("İşlem Başarılı");
        }

        [HttpGet("{code}")]
        public IActionResult GetStock(string code)
        {
            var values = _stockService.TGetByID(code);
            return Ok(_mapper.Map<GetStockDto>(values));
        }
    }
}
