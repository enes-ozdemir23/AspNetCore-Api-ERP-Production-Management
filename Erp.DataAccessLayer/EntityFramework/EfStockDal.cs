using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erp.DataAccessLayer.Abstract;
using Erp.DataAccessLayer.Concrete.Context;
using Erp.DataAccessLayer.Repositories;
using Erp.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Erp.DataAccessLayer.EntityFramework
{
    public class EfStockDal : GenericRepository<Stock, string>, IStockDal
    {
        public EfStockDal(ErpContext context) : base(context)
        {
        }

        public string GetLastStockCodeByGroup(string groupCode)
        {
            var context=new ErpContext();
            var values= context.Stocks
                    .AsNoTracking()
                    .Where(x => x.GroupCode == groupCode)
                    .OrderByDescending(y => y.StockCode)
                    .Select(z => z.StockCode)
                    .FirstOrDefault();
            return values;
        }
    }
}
