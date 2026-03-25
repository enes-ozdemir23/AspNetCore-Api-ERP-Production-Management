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
    public class StockManager : IStockService
    {
        private readonly IStockDal _stockDal;

        public StockManager(IStockDal stockDal)
        {
            _stockDal = stockDal;
        }

        public void TAdd(Stock entity)
        {
            _stockDal.Add(entity);
        }

        public void TDelete(Stock entity)
        {
            _stockDal.Delete(entity);
        }

        public Stock TGetByID(string id)
        {
            return _stockDal.GetByID(id);
        }

        public List<Stock> TGetListAll()
        {
            return _stockDal.GetListAll();
        }

        public void TUpdate(Stock entity)
        {
            _stockDal.Update(entity);
        }
    }
}
