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
        private readonly ICodeGeneratorService _codegenService;
        public StockManager(IStockDal stockDal, ICodeGeneratorService codegenService)
        {
            _stockDal = stockDal;
            _codegenService = codegenService;
        }

        public void TAdd(Stock entity)
        {
            entity.GroupCode = entity.GroupCode.PadLeft(2, '0');
            var lastCode = _stockDal.GetLastStockCodeByGroup(entity.GroupCode);
            entity.StockCode = _codegenService.GenerateStockCode(lastCode,entity.GroupCode);
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

        public string TGetLastStockCodeByGroup(string groupCode)
        {
            return _stockDal.GetLastStockCodeByGroup(groupCode);
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
