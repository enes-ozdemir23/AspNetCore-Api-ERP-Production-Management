using AutoMapper;
using Erp.DtoLayer.AboutDto;
using Erp.EntityLayer.Entities;

namespace ErpApi.Mapping
{
    public class AboutMapping:Profile
    {
        public AboutMapping()
        {
            CreateMap<CreateAboutDto,About>().ReverseMap();
            CreateMap<GetAboutDto,About>().ReverseMap();
            CreateMap<ResultAboutDto,About>().ReverseMap();
            CreateMap<UpdateAboutDto,About>().ReverseMap();
        }
    }
}
