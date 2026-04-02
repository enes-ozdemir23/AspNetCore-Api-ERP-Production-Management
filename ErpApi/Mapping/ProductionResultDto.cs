using AutoMapper;
using Erp.DtoLayer.ProductionResultDto;
using Erp.EntityLayer.Entities;

namespace ErpApi.Mapping
{
    public class ProductionResultDto:Profile
    {
        public ProductionResultDto()
        {
            CreateMap<ProductionResult,ResultProductionResultDto>().ReverseMap();
            CreateMap<ProductionResult,GetProductionResultDto>().ReverseMap();
            CreateMap<ProductionResult,CreateProductionResultDto>().ReverseMap();
            CreateMap<ProductionResult,UpdateProductionResultDto>().ReverseMap();
        }
    }
}
