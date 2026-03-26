using Erp.BusinessLayer.Abstract;
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

        public DistrictsController(IDistrictService districtService)
        {
            _districtService = districtService;
        }
        [HttpGet]
        public IActionResult DistrictList()
        {
            var values=_districtService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddDistrict(District district)
        {
            _districtService.TAdd(district);
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
        public IActionResult UpdateDistrict(District district)
        {
            _districtService.TUpdate(district);
            return Ok("İşlem Başarılı");
        }

        [HttpGet("{id}")]
        public IActionResult GetDistrict(int id)
        {
            var values = _districtService.TGetByID(id);
            return Ok(values);
        }
    }
}
