using AutoMapper;
using Erp.DtoLayer.StockMovementDto;
using Erp.EntityLayer.Entities;

namespace ErpApi.Mapping
{
    public class StockMovementMapping:Profile
    {
        public StockMovementMapping()
        {
            CreateMap<StockMovement,ResultStockMovementDto>().ReverseMap();
            CreateMap<StockMovement,GetStockMovementDto>().ReverseMap();
            CreateMap<StockMovement,CreateStockMovementDto>().ReverseMap();
            CreateMap<StockMovement,UpdateStockMovementDto>().ReverseMap();
        }
    }
}
