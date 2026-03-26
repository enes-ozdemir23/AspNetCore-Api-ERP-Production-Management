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
    public class StockMovementManager : IStockMovementService
    {
        private readonly IStockMovementDal _stockMovementDal;

        public StockMovementManager(IStockMovementDal stockMovementDal)
        {
            _stockMovementDal = stockMovementDal;
        }

        public void TAdd(StockMovement entity)
        {
            _stockMovementDal.Add(entity);
        }

        public void TDelete(StockMovement entity)
        {
            _stockMovementDal.Delete(entity);
        }

        public StockMovement TGetByID(int id)
        {
            return _stockMovementDal.GetByID(id);
        }

        public List<StockMovement> TGetListAll()
        {
            return _stockMovementDal.GetListAll();
        }

        public void TUpdate(StockMovement entity)
        {
            _stockMovementDal.Update(entity);
        }
    }
}
