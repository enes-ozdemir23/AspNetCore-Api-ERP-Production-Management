using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erp.EntityLayer.Entities;

namespace Erp.BusinessLayer.Abstract
{
    public interface IStockService:IGenericService<Stock,string>
    {
        public string TGetLastStockCodeByGroup(string groupCode);

        List<Stock> TGetStocksByGroupCode(string groupCode);


    }
}
