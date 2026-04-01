using AutoMapper;
using Erp.BusinessLayer.Abstract;
using Erp.DtoLayer.StockMovementDto;
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
        private readonly IMapper _mapper;
        public StockMovementsController(IStockMovementService stockMovementService, IMapper mapper)
        {
            _stockMovementService = stockMovementService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult StockMovementList()
        {
            var values = _mapper.Map<List<ResultStockMovementDto>>(_stockMovementService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddStockMovement(CreateStockMovementDto createStockMovementDto)
        {
            var values=_mapper.Map<StockMovement>(createStockMovementDto);
            _stockMovementService.TAdd(values);
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
        public IActionResult UpdateStockMovement(UpdateStockMovementDto updateStockMovementDto)
        {
            var values=_mapper.Map<StockMovement>(updateStockMovementDto);
            _stockMovementService.TUpdate(values);
            return Ok("İşlem Başarılı");

        }

        [HttpGet("{id}")]
        public IActionResult GetStockMovement(int id)
        {
            var values = _stockMovementService.TGetByID(id);
            return Ok(_mapper.Map<GetStockMovementDto>(values));
        }
    }
}
