using AutoMapper;
using Erp.DtoLayer.CityDto;
using Erp.DtoLayer.DistrictDto;
using Erp.EntityLayer.Entities;

namespace ErpApi.Mapping
{
    public class DistrictMapping:Profile
    {
        public DistrictMapping()
        {
            CreateMap<District, ResultDistrictDto>().ReverseMap();
            CreateMap<District, GetDistrictDto>().ReverseMap();
            CreateMap<District, UpdateDistrictDto>().ReverseMap();
            CreateMap<District, CreateDistrictDto>().ReverseMap();

        }
    }
}
