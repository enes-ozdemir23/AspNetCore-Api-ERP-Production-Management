using AutoMapper;
using Erp.DtoLayer.DistrictDto;
using Erp.DtoLayer.StockDto;
using Erp.EntityLayer.Entities;

namespace ErpApi.Mapping
{
    public class StockMapping:Profile
    {
        public StockMapping()
        {
            CreateMap<Stock, ResultStockDto>().ReverseMap();
            CreateMap<Stock, CreateStockDto>().ReverseMap();
            CreateMap<Stock, UpdateStockDto>().ReverseMap();
            CreateMap<Stock, GetStockDto>().ReverseMap();

        }
    }
}
