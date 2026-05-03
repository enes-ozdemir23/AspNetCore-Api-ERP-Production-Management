using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erp.EntityLayer.Entities;

namespace Erp.DataAccessLayer.Abstract
{
    public interface IStockDal:IGenericDal<Stock,string>
    {
        public string GetLastStockCodeByGroup(string groupCode);

        List<Stock> GetStocksByGroupCode(string groupCode);

    }
}
