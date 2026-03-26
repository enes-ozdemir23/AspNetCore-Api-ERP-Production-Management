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
    public class ProductionResultManager : IProductionResultService
    {
        private readonly IProductionResultDal _productionResultDal;

        public ProductionResultManager(IProductionResultDal productionResultDal)
        {
            _productionResultDal = productionResultDal;
        }

        public void TAdd(ProductionResult entity)
        {
            _productionResultDal.Add(entity);
        }

        public void TDelete(ProductionResult entity)
        {
            _productionResultDal.Delete(entity);
        }

        public ProductionResult TGetByID(string id)
        {
            return _productionResultDal.GetByID(id);    
        }

        public List<ProductionResult> TGetListAll()
        {
            return _productionResultDal.GetListAll();
        }

        public void TUpdate(ProductionResult entity)
        {
            _productionResultDal.Update(entity);
        }
    }
}
