using AutoMapper;
using Erp.BusinessLayer.Abstract;
using Erp.DtoLayer.CityDto;
using Erp.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ErpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICityService _cityService;
        private readonly IMapper _mapper;

        public CitiesController(ICityService cityService, IMapper mapper)
        {
            _cityService = cityService;
            _mapper = mapper;
        } 

        [HttpGet] 
        public IActionResult CitiesList()
        {
            var values = _mapper.Map<List<ResultCityDto>>(_cityService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddCities(CreateCityDto createCityDto)
        {
            var value = _mapper.Map<City>(createCityDto);
            _cityService.TAdd(value);
            return Ok("İşlem Başarılı");
        }
        [HttpDelete]
        public IActionResult DeleteCities(int id)
        {
            var values = _cityService.TGetByID(id);
            _cityService.TDelete(values);
            return Ok("İşlem Başarılı");
        }
        [HttpPut]
        public IActionResult UpdateCities(UpdateCityDto updateCityDto)
        {
            var values=_mapper.Map<City>(updateCityDto);
            _cityService.TUpdate(values);
            return Ok("Güncelleme Başarılı");
        }

        [HttpGet("{id}")]
        public IActionResult GetCities(int id)
        {
            var value = _cityService.TGetByID(id);
            return Ok(_mapper.Map<GetCityDto>(value));
        }
    }
}
