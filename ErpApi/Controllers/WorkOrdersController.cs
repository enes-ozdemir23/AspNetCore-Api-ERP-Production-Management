using Erp.BusinessLayer.Abstract;
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

        public WorkOrdersController(IWorkOrderService workOrderService)
        {
            _workOrderService = workOrderService;
        }

        [HttpGet]
        public IActionResult WorkOrderList()
        {
            var values = _workOrderService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddWorkOrder(WorkOrder workOrder)
        {
            _workOrderService.TAdd(workOrder);
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
        public IActionResult UpdateWorkOrder(WorkOrder workOrder)
        {
            _workOrderService.TUpdate(workOrder);
            return Ok("İşlem Başarılı");
        }

        [HttpGet("{code}")]
        public IActionResult GetWorkOrder(String code)
        {
            var values = _workOrderService.TGetByID(code);
            return Ok(values);
        }

    }
}
    
