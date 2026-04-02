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
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;
        private readonly ICodeGeneratorService _codegenService;
        public OrderManager(IOrderDal orderDal, ICodeGeneratorService codegenService)
        {
            _orderDal = orderDal;
            _codegenService = codegenService;
        }

        public string GetLastOrderCode()
        {
            return _orderDal.GetLastOrderCode();
        }

        public void TAdd(Order entity)
        {
            // 1️ Son kodu al
            var lastCode = _orderDal.GetLastOrderCode();

            // 2️ Yeni kod üret
            var newCode = _codegenService.GenerateSequential(lastCode, "S", 10);

            // 3️ Entity'ye ata
            entity.OrderCode = newCode;

            // 4️ Kaydet
            _orderDal.Add(entity);
        }

        public void TDelete(Order entity)
        {
            _orderDal.Delete(entity);
        }

        public Order TGetByID(string id)
        {
            return _orderDal.GetByID(id);
        }

        public List<Order> TGetListAll()
        {
            return _orderDal.GetListAll();
        }

        public void TUpdate(Order entity)
        {
            _orderDal.Update(entity);
        }
    }
}
