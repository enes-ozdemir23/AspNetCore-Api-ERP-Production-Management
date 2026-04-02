using AutoMapper;
using Erp.BusinessLayer.Abstract;
using Erp.DtoLayer.GroupCodeDto;
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
        private readonly IMapper _mapper;
        public GroupCodesController(IGroupCodeService groupCodeService, IMapper mapper)
        {
            _groupCodeService = groupCodeService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GroupCodeList()
        {
            var values=_mapper.Map<List<ResultGroupCodeDto>>(_groupCodeService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddGroupCode(CreateGroupCodeDto createGroupCodeDto)
        {
            var values=_mapper.Map<GroupCode>(createGroupCodeDto);
            _groupCodeService.TAdd(values);
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
        public IActionResult UpdateGroupCode(UpdateGroupCodeDto updateGroupCodeDto)
        {
            var values=_mapper.Map<GroupCode>(updateGroupCodeDto);
            _groupCodeService.TUpdate(values);
            return Ok("İşlem Başarılı");
        }

        [HttpGet("{code}")]
        public IActionResult GetGroupCode(string code)
        {
            var values=_groupCodeService.TGetByID(code);
            return Ok(_mapper.Map<GetGroupCodeDto>(values));
        }
    }
}
