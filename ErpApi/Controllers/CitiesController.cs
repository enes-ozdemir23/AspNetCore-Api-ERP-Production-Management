using Erp.BusinessLayer.Abstract;
using Erp.DataAccessLayer.Concrete.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ErpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CitiesController(ICityService cityService)
        {
            _cityService = cityService;
        }
        [HttpGet]
        public IActionResult CitiesList()
        {
            var values = _cityService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddCities(City city)
        {
            _cityService.TAdd(city);
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
        public IActionResult UpdateCities(City city)
        {
            _cityService.TUpdate(city);
            return Ok("Güncelleme Başarılı");
        }

        [HttpGet("{id}")]
        public IActionResult GetCities(int id)
        {
            var values = _cityService.TGetByID(id);
            return Ok(values);
        }
    }
}
