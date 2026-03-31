using AutoMapper;
using Erp.BusinessLayer.Abstract;
using Erp.DtoLayer.CityDto;
using Erp.DtoLayer.DistrictDto;
using Erp.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ErpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictsController : ControllerBase
    {
        private readonly IDistrictService _districtService;
        private readonly IMapper _mapper;

        public DistrictsController(IDistrictService districtService, IMapper mapper)
        {
            _districtService = districtService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult DistrictList()
        {
            var values = _mapper.Map<List<ResultDistrictDto>>(_districtService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddDistrict(CreateDistrictDto createDistrictDto)
        {
            var value = _mapper.Map<District>(createDistrictDto);
            _districtService.TAdd(value);
            return Ok("İşlem Başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteDistrict(int id)
        {
            var values=_districtService.TGetByID(id);
            _districtService.TDelete(values);
            return Ok("İşlem Başarılı");
        }

        [HttpPut]
        public IActionResult UpdateDistrict(UpdateDistrictDto updateDistrictDto)
        {
            var values = _mapper.Map<District>(updateDistrictDto);
            _districtService.TUpdate(values);
            return Ok("İşlem Başarılı");
        }

        [HttpGet("{id}")]
        public IActionResult GetDistrict(int id)
        {
            var values = _districtService.TGetByID(id);
            return Ok(_mapper.Map<GetDistrictDto>(values));
        }
    }
}
