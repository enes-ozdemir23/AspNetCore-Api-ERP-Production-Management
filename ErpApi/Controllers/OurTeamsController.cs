using AutoMapper;
using Erp.BusinessLayer.Abstract;
using Erp.DtoLayer.OurTeamDto;
using Erp.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ErpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OurTeamsController : ControllerBase
    {
        private readonly IOurTeamService _ourTeamService;
        private readonly IMapper _mapper;

        public OurTeamsController(IOurTeamService ourTeamService, IMapper mapper)
        {
            _ourTeamService = ourTeamService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult OurTeamList()
        {
            var values = _mapper.Map<List<ResultOurTeamDto>>(_ourTeamService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddOurTeam(CreateOurTeamDto createOurTeamDto)
        {
            var values = _mapper.Map<OurTeam>(createOurTeamDto);
            _ourTeamService.TAdd(values);
            return Ok("İşlem Başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteOurTeam(int id)
        {
            var values = _ourTeamService.TGetByID(id);
            _ourTeamService.TDelete(values);
            return Ok("İşlem Başarılı");
        }

        [HttpPut]
        public IActionResult UpdateOurTeam(UpdateOurTeamDto updateOurTeamDto)
        {
            var values = _mapper.Map<OurTeam>(updateOurTeamDto);
            _ourTeamService.TUpdate(values);
            return Ok("İşlem Başarılı");
        }

        [HttpGet("{id}")]
        public IActionResult GetOurTeam(int id)
        {
            var values = _ourTeamService.TGetByID(id);
            return Ok(_mapper.Map<GetOurTeamDto>(values));

        }
    }
}
