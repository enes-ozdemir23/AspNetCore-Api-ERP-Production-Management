using Erp.BusinessLayer.Abstract;
using Erp.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ErpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupCodesController : ControllerBase
    {
        private readonly IGroupCodeService _groupCodeService;

        public GroupCodesController(IGroupCodeService groupCodeService)
        {
            _groupCodeService = groupCodeService;
        }

        [HttpGet]
        public IActionResult GroupCodeList()
        {
            var values=_groupCodeService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddGroupCode(GroupCode groupCode)
        {
            _groupCodeService.TAdd(groupCode);
            return Ok("İşlem Başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteGroupCode(string code)
        {
            var values = _groupCodeService.TGetByID(code);
            _groupCodeService.TDelete(values);
            return Ok("İşlem Başarılı");
        }

        [HttpPut]
        public IActionResult UpdateGroupCode(GroupCode groupCode)
        {
            _groupCodeService.TUpdate(groupCode);
            return Ok("İşlem Başarılı");
        }

        [HttpGet("{code}")]
        public IActionResult GetGroupCode(string code)
        {
            var values=_groupCodeService.TGetByID(code);
            return Ok(values);
        }
    }
}
