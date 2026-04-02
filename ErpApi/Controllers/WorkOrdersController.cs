using AutoMapper;
using Erp.BusinessLayer.Abstract;
using Erp.DtoLayer.WorkOrderDto;
using Erp.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Mvc;

namespace ErpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkOrdersController : ControllerBase
    {
        private readonly IWorkOrderService _workOrderService;
        private readonly IMapper _mapper;
        public WorkOrdersController(IWorkOrderService workOrderService, IMapper mapper)
        {
            _workOrderService = workOrderService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult WorkOrderList()
        {
            var values = _mapper.Map<List<ResultWorkOrderDto>>(_workOrderService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddWorkOrder(CreateWorkOrderDto createWorkOrderDto)
        {
            var values=_mapper.Map<WorkOrder>(createWorkOrderDto);
            _workOrderService.TAdd(values);
            return Ok("İşlem Başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteWorkOrder(String code)
        {
            var values=_workOrderService.TGetByID(code);
            _workOrderService.TDelete(values);
            return Ok("İşlem Başarılı");
        }

        [HttpPut]
        public IActionResult UpdateWorkOrder(UpdateWorkOrderDto updateWorkOrderDto)
        {
            var values = _mapper.Map<WorkOrder>(updateWorkOrderDto);
            _workOrderService.TUpdate(values);
            return Ok("İşlem Başarılı");
        }

        [HttpGet("{code}")]
        public IActionResult GetWorkOrder(String code)
        {
            var values = _workOrderService.TGetByID(code);
            return Ok(_mapper.Map<GetWorkOrderDto>(values));
        }

    }
}
    
