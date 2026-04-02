using AutoMapper;
using Erp.DtoLayer.WorkOrderDto;
using Erp.EntityLayer.Entities;

namespace ErpApi.Mapping
{
    public class WorkOrderMapping:Profile
    {
        public WorkOrderMapping()
        {
            CreateMap<WorkOrder,ResultWorkOrderDto>().ReverseMap();
            CreateMap<WorkOrder,GetWorkOrderDto>().ReverseMap();
            CreateMap<WorkOrder,CreateWorkOrderDto>().ReverseMap();
            CreateMap<WorkOrder,UpdateWorkOrderDto>().ReverseMap();
        }
    }
}
