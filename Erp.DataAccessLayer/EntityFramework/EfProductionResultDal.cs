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
    public class EfProductionResultDal : GenericRepository<ProductionResult, string>, IProductionResultDal
    {
        public EfProductionResultDal(ErpContext context) : base(context)
        {
        }

        public string GetLastProductionResultCode()
        {
            var context = new ErpContext();
            var value = context.ProductionResults
                        .OrderByDescending(x => x.ProductionResultCode)
                        .Select(y => y.ProductionResultCode)
                        .FirstOrDefault();
            return value;
        }
    }
}
