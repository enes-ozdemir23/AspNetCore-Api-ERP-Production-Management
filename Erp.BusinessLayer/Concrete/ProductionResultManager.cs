using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erp.BusinessLayer.Abstract;
using Erp.DataAccessLayer.Abstract;
using Erp.DataAccessLayer.EntityFramework;
using Erp.EntityLayer.Entities;

namespace Erp.BusinessLayer.Concrete
{
    public class ProductionResultManager : IProductionResultService
    {
        private readonly IProductionResultDal _productionResultDal;
        private readonly ICodeGeneratorService _codegenService;


        public ProductionResultManager(IProductionResultDal productionResultDal, ICodeGeneratorService codegenService)
        {
            _productionResultDal = productionResultDal;
            _codegenService = codegenService;
        }

        public string TGetLastProductionResultCode()
        {
            return _productionResultDal.GetLastProductionResultCode();
        }

        public void TAdd(ProductionResult entity)
        {

            var lastCode = _productionResultDal.GetLastProductionResultCode();
            var newCode = _codegenService.GenerateSequential(lastCode, "U", 10);
            entity.ProductionResultCode = newCode;
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
