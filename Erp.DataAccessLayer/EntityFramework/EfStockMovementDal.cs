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
    public class EfStockMovementDal : GenericRepository<StockMovement, int>, IStockMovementDal
    {
        public EfStockMovementDal(ErpContext context) : base(context)
        {
        }
    }
}
