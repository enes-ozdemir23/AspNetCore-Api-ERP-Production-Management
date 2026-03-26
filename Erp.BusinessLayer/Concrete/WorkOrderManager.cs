using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erp.BusinessLayer.Abstract;
using Erp.DataAccessLayer.Abstract;
using Erp.EntityLayer.Entities;

namespace Erp.BusinessLayer.Concrete
{
    public class WorkOrderManager : IWorkOrderService
    {
        private readonly IWorkOrderDal _workOrderDal;

        public WorkOrderManager(IWorkOrderDal workOrderDal)
        {
            _workOrderDal = workOrderDal;
        }

        public void TAdd(WorkOrder entity)
        {
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
