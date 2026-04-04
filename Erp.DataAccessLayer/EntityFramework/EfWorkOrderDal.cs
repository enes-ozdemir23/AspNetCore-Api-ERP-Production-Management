using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erp.DataAccessLayer.Abstract;
using Erp.DataAccessLayer.Concrete.Context;
using Erp.DataAccessLayer.Repositories;
using Erp.EntityLayer.Entities;

namespace Erp.DataAccessLayer.EntityFramework
{
    public class EfWorkOrderDal : GenericRepository<WorkOrder, string>, IWorkOrderDal
    {
        public EfWorkOrderDal(ErpContext context) : base(context)
        {
        }

        public string GetLastWorkOrderCode()
        {
            var context = new ErpContext();
            var value = context.WorkOrders
                        .OrderByDescending(x => x.WorkOrderCode)
                        .Select(y => y.WorkOrderCode)
                        .FirstOrDefault();
            return value;
        }
    }
}
