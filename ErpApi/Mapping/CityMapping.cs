using AutoMapper;
using Erp.DtoLayer.CityDto;
using Erp.EntityLayer.Entities;

namespace ErpApi.Mapping
{
    public class CityMapping:Profile
    {
        public CityMapping()
        {
            CreateMap<City,ResultCityDto>().ReverseMap();
            CreateMap<City,CreateCityDto>().ReverseMap();
            CreateMap<City,GetCityDto>().ReverseMap();
            CreateMap<City,UpdateCityDto>().ReverseMap();
        }
    }
}
