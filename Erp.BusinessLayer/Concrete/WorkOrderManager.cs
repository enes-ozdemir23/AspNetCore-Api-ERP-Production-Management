using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erp.BusinessLayer.Abstract;
using Erp.DataAccessLayer.Abstract;
using Erp.DataAccessLayer.EntityFramework;
using Erp.EntityLayer.Entities;

namespace Erp.BusinessLayer.Concrete
{
    public class WorkOrderManager : IWorkOrderService
    {
        private readonly IWorkOrderDal _workOrderDal;
        private readonly ICodeGeneratorService _codegenService;

        public WorkOrderManager(IWorkOrderDal workOrderDal, ICodeGeneratorService codegenService)
        {
            _workOrderDal = workOrderDal;
            _codegenService = codegenService;
        }

        public void TAdd(WorkOrder entity)
        {
            var lastCode = _workOrderDal.GetLastWorkOrderCode();
            var newCode = _codegenService.GenerateSequential(lastCode, "I", 10);
            entity.WorkOrderCode = newCode;
            _workOrderDal.Add(entity);
        }

        public void TDelete(WorkOrder entity)
        {
            _workOrderDal.Delete(entity);
        }

        public WorkOrder TGetByID(string id)
        {
            return _workOrderDal.GetByID(id);
        }

        public string TGetLastWorkOrderCode()
        {
            return _workOrderDal.GetLastWorkOrderCode();
        }

        public List<WorkOrder> TGetListAll()
        {
            return _workOrderDal.GetListAll();
        }

        public void TUpdate(WorkOrder entity)
        {
            _workOrderDal.Update(entity);
        }
    }
}
