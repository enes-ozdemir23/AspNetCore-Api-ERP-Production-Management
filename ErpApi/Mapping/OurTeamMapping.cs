using AutoMapper;
using Erp.DtoLayer.OurTeamDto;
using Erp.EntityLayer.Entities;

namespace ErpApi.Mapping
{
    public class OurTeamMapping:Profile
    {
        public OurTeamMapping()
        {
            CreateMap<OurTeam, ResultOurTeamDto>().ReverseMap();
            CreateMap<OurTeam, GetOurTeamDto>().ReverseMap();
            CreateMap<OurTeam, UpdateOurTeamDto>().ReverseMap();
            CreateMap<OurTeam, CreateOurTeamDto>().ReverseMap();
        }
    }
}
