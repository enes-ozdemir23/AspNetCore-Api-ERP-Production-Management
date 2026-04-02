using AutoMapper;
using Erp.DtoLayer.GroupCodeDto;
using Erp.EntityLayer.Entities;

namespace ErpApi.Mapping
{
    public class GroupCodeMapping:Profile
    {
        public GroupCodeMapping()
        {
            CreateMap<GroupCode,ResultGroupCodeDto>().ReverseMap();
            CreateMap<GroupCode,GetGroupCodeDto>().ReverseMap();
            CreateMap<GroupCode,CreateGroupCodeDto>().ReverseMap();
            CreateMap<GroupCode,UpdateGroupCodeDto>().ReverseMap();
        }
    }
}
